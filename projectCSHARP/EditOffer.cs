using projectCSHARP.Classes;
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
    public partial class EditOffer : Form
    {
        private readonly Offer _offertos;
        public EditOffer(Offer offer)
        {
            InitializeComponent();
            _offertos = offer;
        }

        private void EditOffer_Load(object sender, EventArgs e)
        {
            tbId.Text=_offertos.offerId.ToString();
            tbName.Text = _offertos.offerName;
            tbPrice.Text = _offertos.biddingPrice.ToString();
        }


        private void btOk_Click(object sender, EventArgs e)
        {
            _offertos.offerId = int.Parse(tbId.Text);
            _offertos.offerName = tbName.Text;
            _offertos.biddingPrice = int.Parse(tbPrice.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
