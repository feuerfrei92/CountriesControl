using CountriesControlServices;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CountriesControlUI
{
    [System.ComponentModel.DefaultBindingProperty("SelectedCountry")]
    [Designer(typeof(CountriesControlDesigner))]
    public partial class CountriesControl : UserControl
    {
        private Country _selectedCountry;
        private string _description;

        [Browsable(true)]
        [Category("Action")]
        [Description("Shows the next country in the list.")]
        public event EventHandler MoveNext;

        [Browsable(true)]
        [Category("Action")]
        [Description("Shows the previous country in the list.")]
        public event EventHandler MovePrevious;

        [Browsable(true)]
        [Category("Action")]
        [Description("Changes the description of the selected country.")]
        public event EventHandler DescriptionChanged;

        [Browsable(true)]
        [Category("Action")]
        [Description("Deletes the selected country.")]
        public event EventHandler CountryDeleted;

        [Browsable(true)]
        [Category("Action")]
        [Description("Restores deleted countries.")]
        public event EventHandler RestoreCountries;

        public Country SelectedCountry
        {
            get
            {
                return _selectedCountry;
            }
            set
            {
                _selectedCountry = value;
                if (_selectedCountry != null)
                {
                    RefreshInfo();
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                if (_description != tb_Description.Text)
                {
                    tb_Description.Text = _description;
                }
            }
        }

        public CountriesControl()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (this.MoveNext != null)
            {
                this.MoveNext(sender, e);
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (this.MovePrevious != null)
            {
                this.MovePrevious(sender, e);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.CountryDeleted != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected country?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.CountryDeleted(sender, e);
                }
            }
        }

        private void btn_UndoDelete_Click(object sender, EventArgs e)
        {
            if (this.RestoreCountries != null)
            {
                this.RestoreCountries(sender, e);
            }
        }

        private void btn_ChangeDescription_Click(object sender, EventArgs e)
        {
            if (_selectedCountry.Description != tb_Description.Text && this.DescriptionChanged != null)
            {
                _description = tb_Description.Text;
                this.DescriptionChanged(sender, e);
            }
        }

        private void tb_Description_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _selectedCountry.Description != tb_Description.Text && this.DescriptionChanged != null)
            {
                _description = tb_Description.Text;
                var ev = new EventArgs();
                this.DescriptionChanged(sender, ev);
            }
        }

        private void RefreshInfo()
        {
            pb_Flag.ImageLocation = Path.Combine(Commons.FlagsPath, _selectedCountry.Flag);
            lbl_CountryName.Text = _selectedCountry.Name;
            lbl_CapitalName.Text = _selectedCountry.Capital;
            tb_Description.Text = _selectedCountry.Description;
        }  
    }

    public class CountriesControlDesigner : ControlDesigner
    {
        private DesignerActionListCollection lists;
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (lists == null)
                {

                    lists = new DesignerActionListCollection();
                    lists.Add(new CountriesControlActionList(this.Component));
                }
                return lists;
            }
        }
    }

    public class CountriesControlActionList : DesignerActionList
    {
        private CountriesControl _countriesControl;
        private DesignerActionUIService _designerActionService;

        public CountriesControlActionList(IComponent component)
            : base(component)
        {
            _countriesControl = (CountriesControl)component;
            _designerActionService = (DesignerActionUIService)GetService(typeof(DesignerActionUIService));
        }

        private PropertyDescriptor GetPropertyByName(string propName)
        {
            PropertyDescriptor prop = default(PropertyDescriptor);
            prop = TypeDescriptor.GetProperties(_countriesControl)[propName];
            if (prop == null)
            {
                throw new ArgumentException("Invalid Property", propName);
            }
            else
            {
                return prop;
            }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection item = new DesignerActionItemCollection();
            item.Add(new DesignerActionHeaderItem("Description"));
            item.Add(new DesignerActionPropertyItem(
                       "Description", "Description", "Country description", "Edit the country's decription"));
            return item;
        }

        public string Description
        {
            get { return _countriesControl.Description; }
            set { GetPropertyByName("Description").SetValue(_countriesControl, value); }
        }
    }
}
