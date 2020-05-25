using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountriesControlServices.Interfaces;
using CountriesControlServices;
using System.ComponentModel.Composition;

namespace CountriesControlUI
{
    [System.ComponentModel.DefaultBindingProperty("SelectedCountry")]
    public partial class DataControl : UserControl, INotifyPropertyChanged
    {
        private ICountryService _countryService;
        private Country _selectedCountry;

        public DataControl()
        {
            InitializeComponent();
        }

        [Import]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICountryService CountryService
        {
            get
            {
                return _countryService;
            }
            set
            {
                _countryService = value;
                _selectedCountry = _countryService.RefreshCurrentCountry();
            }
        }

        public Country SelectedCountry
        {
            get
            {
                return _selectedCountry;
            }
            set
            {
                _selectedCountry = value;
                PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
            }
        }

        public void Next()
        {
            _selectedCountry = _countryService.GetNextCountry();
            PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
        }

        public void Prev()
        {
            _selectedCountry = _countryService.GetPreviousCountry();
            PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
        }

        public void Delete()
        {
            _countryService.DeleteCountry(_selectedCountry.Name);
            _selectedCountry = _countryService.RefreshCurrentCountry();
            PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
        }

        public void Undelete()
        {
            _countryService.RestoreDeletedCountries();
            _selectedCountry = _countryService.RefreshCurrentCountry();
            PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
        }

        public void ChangeDescription(string description)
        {
            _countryService.ChangeDescription(_selectedCountry.Name, description);
            _selectedCountry = _countryService.RefreshCurrentCountry();
            PropertyChanged(this, new PropertyChangedEventArgs("SelectedCountry"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
