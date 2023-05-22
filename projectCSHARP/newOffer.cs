using projectCSHARP.Classes;
using projectCSHARP.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace projectCSHARP
{
    public partial class newOffer : Form
    {
        private List<Offer> _offer;
       
        public newOffer()
        {
            InitializeComponent();
            _offer = new List<Offer>();
            
        }

        public void displayOffers()
        {
            dataGridViewOffers.Rows.Clear();
            foreach(Offer offer in _offer)
            {
                int rowId = dataGridViewOffers.Rows.Add(offer.offerId, offer.offerName, offer.biddingPrice);
                dataGridViewOffers.Rows[rowId].Tag = offer;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(tbId.Text);
            string NAME = tbName.Text;
            float OFFER = float.Parse(tbOffer.Text);

            Offer offer = new Offer (NAME, ID, OFFER);
            _offer.Add(offer);

            displayOffers();

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOffers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a participant");
                return;
            }

            if (dataGridViewOffers.SelectedRows.Count > 0)
            {
               

                DataGridViewRow row = dataGridViewOffers.SelectedRows[0];  //selectam randul
                 Offer offer = (Offer)row.Tag;      //selectam obiectul

                EditOffer Form = new EditOffer(offer);
                Form.ShowDialog();
                displayOffers();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOffers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewOffers.SelectedRows[0];  //selectam randul
                Offer  waiter = (Offer)row.Tag;      //selectam obiectul

                _offer.Remove(waiter);
                displayOffers();
            }
        }

        private void tbId_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Enter your bidder id";
        }

        private void tbName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Enter what are you willing to bid on ";
        }

        private void tbOffer_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Enter your offer in $ ";
        }

        private void tbId_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void tbName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void tbOffer_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void btAdd_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Click Add to confirm your Offer ";
        }

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void dataGridViewOffers_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void dataGridViewOffers_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Offer Table ";
        }

        private void btEdit_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Click EDIT to change your Offer ";
        }

        private void btDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Click DELETE to remove your Offer";
        }

        private void btEdit_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void btDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " ";
        }

        private void btXML_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btXML, 0, btXML.Height);
        }

        private void xMLSERIALIZATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Offer>));
            using (FileStream stream = File.Create("serialization.xml"))
            {
                xmlSerializer.Serialize(stream, _offer);
            }

        }

        private void xMLDESERIALIZATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Offer>));
            using (FileStream stream = File.OpenRead("serialization.xml"))
            {
                _offer = (List<Offer>)xmlSerializer.Deserialize(stream);
                displayOffers();
            }
        }

        private void newOffer_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        
        }

        private void btXML_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.Control == true && e.KeyCode == Keys.K)
            {
                btXML.PerformClick();
            }
        }

        private void btXML_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = " Press CTRL + K to attempt XML SERIALIZATION";
        }

        private void btXML_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text =  "";
        }

       

    }
}
