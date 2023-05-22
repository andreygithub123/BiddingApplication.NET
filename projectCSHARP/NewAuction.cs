using projectCSHARP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCSHARP
{
    public partial class NewAuction : Form
    {

        private const string ConnectionString = " Data Source = Actiones.db";
        private readonly List<Auction> _auctions;

        public NewAuction()
        {
            InitializeComponent();
            _auctions = new List<Auction>();
        }

        private void DisplayAuctions()
        {
            listViewAuctions.Items.Clear();

            foreach (Auction auction in _auctions)
            {
                var listViewItem = new ListViewItem(auction.auctionId.ToString());
                listViewItem.SubItems.Add(auction.offerId.ToString());
                listViewItem.SubItems.Add(auction.auctionName);
                listViewItem.SubItems.Add(auction.auctionPrice.ToString());

                listViewItem.Tag = auction;

                listViewAuctions.Items.Add(listViewItem);
            }
        }

        private void AddAuction(Auction auction)
        {
            var query = "insert into Actiones(auctionId,offerId, auctionName, auctionPrice)" +
                                " values(@auctionId,@offerId,@auctionName,@auctionPrice);  " +
                                "SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //1. Add the new participant to the database
                var command = new SQLiteCommand(query, connection);

                command.Parameters.AddWithValue("@auctionId", auction.auctionId);
                command.Parameters.AddWithValue("@offerId", auction.offerId);
                command.Parameters.AddWithValue("@auctionName",auction.auctionName);
                command.Parameters.AddWithValue("@auctionPrice",auction.auctionPrice);

               // auction.auctionId = (int)command.ExecuteScalar();

                //2. Add the new participants to the local collection
                _auctions.Add(auction);
            }
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            var newAuctionId = int.Parse(tbAuctionId.Text);
            var newOfferId = int.Parse(tbOfferId.Text);
            var newName = tbName.Text;
            var newPrice = int.Parse(tbPrice.Text);

            var eldorada = new Auction(newAuctionId,newOfferId, newName, newPrice);

            try
            {
                AddAuction(eldorada);
                DisplayAuctions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void LoadAuctions()
        {
            const string query = "SELECT * FROM Actiones";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int auctionid = (int)reader["auctionId"];
                        int offerid = (int)reader["offerId"];
                        string auctionName = (string)reader["auctionName"];
                        int price = (int)reader["auctionPrice"];
                 

                        Auction auction = new Auction(auctionid,offerid, auctionName, price);
                       _auctions.Add(auction);
                        DisplayAuctions();
                    }
                }
            }
        }

        private void NewAuction_Load(object sender, EventArgs e)
        {
            try 
            {
                LoadAuctions();
                DisplayAuctions();
            }

    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAuction(Auction auction)
        {
            const string query = "DELETE FROM Actiones WHERE auctionId=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //Remove from the database
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", auction.auctionId);

                command.ExecuteNonQuery();

                //Remove from the local copy
                _auctions.Remove(auction);
                
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (listViewAuctions.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose an auction");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete auction", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = listViewAuctions.SelectedItems[0];
                    Auction auction = (Auction)selectedItem.Tag;

                    DeleteAuction(auction);

                    DisplayAuctions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
