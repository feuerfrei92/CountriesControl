using CountriesControlServices;
using CountriesControlServices.Interfaces;
using CountriesControlUI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesControlTests
{
    [TestClass]
    public class ControlsTest
    {
        private Mock<ICountryService> _fakeService;
        private DataControl _dataControl;
        private CountriesControl _countriesControl;
        private Country country1, country2;

        public ControlsTest()
        {
            country1 = new Country
            {
                Name = "Greece",
                Flag = "greece.png",
                Capital = "Athens",
                Description = string.Empty
            };

            country2 = new Country
            {
                Name = "Italy",
                Flag = "italy.png",
                Capital = "Rome",
                Description = string.Empty
            };

            _fakeService = new Mock<ICountryService>();
            _dataControl = new DataControl();
            _countriesControl = new CountriesControl();
        }

        [TestMethod]
        public void ControlInitializationTest_Success()
        {
            ArrangeBasic();
            _dataControl.SelectedCountry = country1;

            AssertCountryEquality(country1, _countriesControl.SelectedCountry);
        }

        [TestMethod]
        public void ControlNextCountryTest_Success()
        {
            ArrangeBasic();

            _fakeService.Setup(s => s.GetNextCountry()).Returns(country2);
            _dataControl.Next();

            AssertCountryEquality(country2, _countriesControl.SelectedCountry);
        }

        [TestMethod]
        public void ControlPreviousCountryTest_Success()
        {
            ArrangeBasic();

            _fakeService.Setup(s => s.GetPreviousCountry()).Returns(country2);
            _dataControl.Prev();

            AssertCountryEquality(country2, _countriesControl.SelectedCountry);
        }

        [TestMethod]
        public void RefreshCountryTest_Success()
        {
            ArrangeBasic();
            _dataControl.SelectedCountry = country1;

            AssertCountryEquality(country1, _countriesControl.SelectedCountry);

            _fakeService.Setup(s => s.RefreshCurrentCountry()).Returns(country2);
            _dataControl.Undelete();

            AssertCountryEquality(country2, _countriesControl.SelectedCountry);
        }

        private void ArrangeBasic()
        {
            _fakeService.Setup(s => s.RefreshCurrentCountry()).Returns(country1);
            _dataControl.CreateControl();
            _countriesControl.CreateControl();
            _countriesControl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedCountry", _dataControl, "SelectedCountry", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            _dataControl.CountryService = _fakeService.Object;
        }

        private void AssertCountryEquality(Country actual, Country expected)
        {
            Assert.AreEqual(actual.Name, expected.Name);
            Assert.AreEqual(actual.Flag, expected.Flag);
            Assert.AreEqual(actual.Capital, expected.Capital);
            Assert.AreEqual(actual.Description, expected.Description);
        }
    }
}
