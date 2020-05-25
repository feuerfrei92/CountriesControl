using CountriesControlServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesControlUI
{
    public partial class MainForm : Form
    {
        private DataControl dataControl1 = new DataControl();
        private ICountryService _countryService;

        public MainForm(ICountryService countryService)
        {
            InitializeComponent();
            _countryService = countryService;
            dataControl1.CountryService = _countryService;
        }

        private void countriesControl1_Load(object sender, EventArgs e)
        {
            tlp_UserControls.Controls.Add(dataControl1, 0, 0);
            dataControl1.Dock = DockStyle.Fill;
            dataControl1.Name = "dataControl1";
            dataControl1.Visible = false;

            countriesControl1.DataBindings.Add(new Binding("SelectedCountry", dataControl1, "SelectedCountry", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void countriesControl1_MoveNext(object sender, EventArgs e)
        {
            dataControl1.Next();
        }

        private void countriesControl1_MovePrevious(object sender, EventArgs e)
        {
            dataControl1.Prev();
        }

        private void countriesControl1_DescriptionChanged(object sender, EventArgs e)
        {
            dataControl1.ChangeDescription(countriesControl1.Description);
        }

        private void countriesControl1_CountryDeleted(object sender, EventArgs e)
        {
            dataControl1.Delete();
        }

        private void countriesControl1_RestoreCountries(object sender, EventArgs e)
        {
            dataControl1.Undelete();
        }
    }
}
