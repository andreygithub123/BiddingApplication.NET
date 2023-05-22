using projectCSHARP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCSHARP
{
    public partial class newAccount : Form
    {

        #region Properties
        private List<Bidder> _bidders;
        #endregion

        public newAccount()
        {
            InitializeComponent();
            _bidders = new List<Bidder>();
        }


        //exception handling
        public class SpecialException : ApplicationException
        {
            public SpecialException() { }
            public SpecialException(string message) : base(message) { }

        }

        void displayBidders()
        {
            listView.Items.Clear();

            foreach (Bidder bidder in _bidders)
            {
                var listViewItem = new ListViewItem(bidder.bidderId.ToString());
                listViewItem.SubItems.Add(bidder.lastName);
                listViewItem.SubItems.Add(bidder.firstName);
                listViewItem.SubItems.Add(bidder.deposit.ToString());
                listViewItem.SubItems.Add(bidder.dateOfBirth.ToShortDateString());

                listView.Items.Add(listViewItem);
            }

        }
        
        

        private void btAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            int bidderId = int.Parse(tbId.Text);
            int bidderDeposit = int.Parse(tbDeposit.Text);
            DateTime birthDate = dtpDate.Value;

            var bidder = new Bidder(firstName, lastName, birthDate, bidderId, bidderDeposit);
            _bidders.Add(bidder);


            if (tbFirstName.Text == "")
                errorProvider.SetError(tbFirstName, "Enter your First Name!");
            else if (tbLastName.Text == "")
                errorProvider.SetError(tbLastName, "Enter your Last Name !");
            else if (tbDeposit.Text == "")
                errorProvider.SetError(tbDeposit, "Enter your Deposit Value !");
            else if (tbId.Text == "")
                errorProvider.SetError(tbId, "Enter your id!");
            else if (dtpDate.Text == " ")
                errorProvider.SetError(dtpDate, "Enter your birth date !");
            else
            {
                try
                {
                    Bidder b = new Bidder();
                    b.firstName = tbFirstName.Text;
                    b.lastName = tbLastName.Text;
                    b.bidderId = (Convert.ToInt32(tbId.Text));
                    b.deposit = (Convert.ToInt32(tbDeposit.Text));
                    b.dateOfBirth = (Convert.ToDateTime(dtpDate.Text));

                    throw new SpecialException("Bidder created with succes ! ");
                }
                catch (FormatException exc)
                {
                    MessageBox.Show("Error catch the Format Exception !");
                }
                catch (SpecialException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    errorProvider.Clear();
                }

                if (this.ValidateChildren())
                {
                    MessageBox.Show("Validation succeeded!");
                }
                else
                {
                    MessageBox.Show("Validation failed.");
                }


                displayBidders();

            }
        }


        //last name validating + validated
        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(tbLastName, "The last name should have at least 3 characters");
            }
        }

        private void tbLastName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbLastName, null);
        }


        //first name validating + validated
        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider.SetError(tbLastName, "The first name should have at least 3 characters");
            }
        }

        
        private void tbFirstName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbFirstName, null);
        }

        //new button
        private void btNew_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbDeposit.Text = "";
            dtpDate.Text = "";
        }

        //listview click ( select id index )
        private void listView_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                tbId.Text = listView.SelectedItems[0].SubItems[0].Text;
                tbLastName.Text = listView.SelectedItems[0].SubItems[1].Text;
                tbFirstName.Text = listView.SelectedItems[0].SubItems[2].Text;
                tbDeposit.Text = listView.SelectedItems[0].SubItems[3].Text;
                dtpDate.Text = listView.SelectedItems[0].SubItems[4].Text;
            }
        }


        //update button
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.SelectedItems[0].SubItems[0].Text = tbId.Text;
                listView.SelectedItems[0].SubItems[1].Text = tbLastName.Text;
                listView.SelectedItems[0].SubItems[2].Text = tbFirstName.Text;
                listView.SelectedItems[0].SubItems[3].Text = tbDeposit.Text;
                listView.SelectedItems[0].SubItems[4].Text = dtpDate.Text;
            }
        }


        //remove button
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }


        //remove all button
        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                listView.Items.Clear();

            }
        }


        //binary serialization
        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create("serialized.bin"))
                    formatter.Serialize(stream, _bidders);
            
        }

        //binary deserialization
        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                _bidders = (List<Bidder>)formatter.Deserialize(stream);
                displayBidders();
            }
        }


        //save 2 text file
        private void saveToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                //2. Approach 2 - recommended
                // When compiled, this code in this approach is converted to: try{} finally{}
                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                // Equivalent to:
                // using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(" ID , LastName , FirstName , Deposit , BirthDate ");

                    foreach (var bidder in _bidders)
                    {
                        sw.WriteLine(" \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\" "
                                    , bidder.bidderId.ToString().Replace("\"", "\"\"")
                                    , bidder.lastName.Replace("\"", "\"\"")
                                    , bidder.firstName.Replace("\"", "\"\"")
                                    , bidder.deposit.ToString().Replace("\"", "\"\"")
                                    , bidder.dateOfBirth.ToShortDateString());
                    }
                }
            }
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 24);
            var pageSettings = e.PageSettings;
            var printAreaHeight = e.MarginBounds.Height;
            var printAreaWidth = e.MarginBounds.Width;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_current < _participants.Count)
            {
                
                var currentX = marginLeft;

                //Draw the border of the cell
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                //Draw the text in the cell
                /*e.Graphics.DrawString(
                    _participants[i].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);*/
                // By specifying a LayoutRectangle, we are forcing the text into a specific area, with automatic word wrapping and other features controllable through the StringFormat parameter
                e.Graphics.DrawString(
                    _participants[_currentParticipantIndex].LastName,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                //Update the horizontal drawing coordinate
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _participants[_currentParticipantIndex].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    _participants[_currentParticipantIndex].BirthDate.ToShortDateString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);

                //Update the participant index
                _currentParticipantIndex++;
                //Update the vertifcal drawing coordinate
                currentY += rowHeight;

                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentParticipantIndex = 0;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }


    }
}
