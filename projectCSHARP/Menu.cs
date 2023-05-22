using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectCSHARP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newBidderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccount newacc = new newAccount();
            newacc.ShowDialog();
        }

        private void newOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newOffer newoff = new newOffer();
            newoff.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindingOffer bidoffer = new BindingOffer();
            bidoffer.ShowDialog();  
        }

        private void newAuctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAuction newauction = new NewAuction();
                newauction.ShowDialog();
        }
    }
}
