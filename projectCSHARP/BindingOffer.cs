using projectCSHARP.ViewModel;
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
    public partial class BindingOffer : Form
    {
        private readonly MainFormViewModel _viewModel;
        public BindingOffer()
        {
            InitializeComponent();
            _viewModel = new MainFormViewModel();
        }

        private void BindingOffer_Load(object sender, EventArgs e)
        {
            dataGridViewOffers2.DataSource = _viewModel.BindingOffers;

            //tbLastName.DataBindings.Add("Text", _viewModel, "LastName");
            //Recommended (without magic strings):
            tbId.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.newId));
            tbName.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.newName));
            tbOffer.DataBindings.Add("Text", _viewModel, nameof(MainFormViewModel.newPrice));

        }

        private void btBindingAdd_Click(object sender, EventArgs e)
        {
            _viewModel.AddOffer();
        }
    }
}
