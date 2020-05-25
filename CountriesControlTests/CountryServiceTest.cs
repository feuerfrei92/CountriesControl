using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CountriesControlData.Interfaces;
using CountriesControlServices.Interfaces;
using CountriesControlServices.Implementations;
using CountriesControlData;
using CountriesControlServices;

namespace CountriesControlTests
{
    [TestClass]
    public class CountryServiceTest
    {
        private Mock<ICountryRepository> _fakeRepo;
        private ICountryService _service;
        private List<CountryDTO> _countries;
        private List<PersistedCountry> _persistedCountries;

        public CountryServiceTest()
        {
            _fakeRepo = new Mock<ICountryRepository>();
            _countries = new List<CountryDTO>()
            {
                new CountryDTO { Name = "Greece", Flag = "greece.png", Capital = "Athens", Description = string.Empty, Deleted = false },
                new CountryDTO { Name = "Italy", Flag = "italy.png", Capital = "Rome", Description = string.Empty, Deleted = false }
            };
            _persistedCountries = new List<PersistedCountry>()
            {
                new PersistedCountry 
                {
                    Country = new Country { Name = "Greece", Flag = "greece.png", Capital = "Athens", Description = string.Empty },
                    IsDeleted = false
                },

                new PersistedCountry
                {
                    Country = new Country { Name = "Italy", Flag = "italy.png", Capital = "Rome", Description = string.Empty },
                    IsDeleted = false
                }
            };


            _fakeRepo.Setup(r => r.LoadCountries()).Returns(_countries);
        }

        [TestMethod]
        public void GetNextCountryTest_Success()
        {
            _service = new CountryService(_fakeRepo.Object);

            var country = _service.GetNextCountry();

            AssertCountryEquality(country, _persistedCountries[1].Country);

            country = _service.GetNextCountry();

            AssertCountryEquality(country, _persistedCountries[0].Country);
        }

        [TestMethod]
        public void GetPreviousCountryTest_Success()
        {
            _service = new CountryService(_fakeRepo.Object);

            var country = _service.GetPreviousCountry();

            AssertCountryEquality(country, _persistedCountries[1].Country);

            country = _service.GetPreviousCountry();

            AssertCountryEquality(country, _persistedCountries[0].Country);
        }

        [TestMethod]
        public void ChangeDescriptionTest_Success()
        {
            _countries[0].Description = "Ancient civilization";
            _persistedCountries[0].Country.Description = "Ancient civilization";
            _fakeRepo.Setup(r => r.LoadCountries()).Returns(_countries);
            _service = new CountryService(_fakeRepo.Object);

            _service.ChangeDescription("Greece", "Ancient civilization");
            var country = _service.RefreshCurrentCountry();

            AssertCountryEquality(country, _persistedCountries[0].Country);

            _countries[0].Description = string.Empty;
            _persistedCountries[0].Country.Description = string.Empty;
            _fakeRepo.Setup(r => r.LoadCountries()).Returns(_countries);
        }

        [TestMethod]
        public void DeleteCountryTest_Success()
        {
            _service = new CountryService(_fakeRepo.Object);

            _service.DeleteCountry("Greece");
            var country = _service.RefreshCurrentCountry();

            AssertCountryEquality(country, _persistedCountries[1].Country);

            country = _service.GetNextCountry();

            AssertCountryEquality(country, _persistedCountries[1].Country);
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
