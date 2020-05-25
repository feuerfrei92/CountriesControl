using CountriesControlData.Interfaces;
using CountriesControlServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlServices.Implementations
{
    public class CountryService : ICountryService
    {
        int _currentIndex;
        ICountryRepository _repo;
        private List<PersistedCountry> _countries;

        public CountryService(ICountryRepository repo)
        {
            _countries = new List<PersistedCountry>();
            _repo = repo;

            LoadCountries();
        }

        public Country RefreshCurrentCountry()
        {
            return _countries[_currentIndex].Country;
        }

        public Country GetNextCountry()
        {
            do
            {
                if (_currentIndex < _countries.Count - 1)
                {
                    _currentIndex++;
                }
                else
                {
                    _currentIndex = 0;
                }
            }
            while (_countries[_currentIndex].IsDeleted);

            return _countries[_currentIndex].Country;
        }

        public Country GetPreviousCountry()
        {
            do
            {
                if (_currentIndex > 0)
                {
                    _currentIndex--;
                }
                else
                {
                    _currentIndex = _countries.Count - 1;
                }
            }
            while (_countries[_currentIndex].IsDeleted);

            return _countries[_currentIndex].Country;
        }

        public void ChangeDescription(string name, string description)
        {
            _repo.UpdateCountryDescription(name, description);
            _countries.First(c => c.Country.Name == name).Country.Description = description;
        }

        public void DeleteCountry(string name)
        {
            _repo.DeleteCountry(name);
            _countries.First(c => c.Country.Name == name).IsDeleted = true;
            _currentIndex++;
        }

        public void RestoreDeletedCountries()
        {
            string name = _countries[_currentIndex].Country.Name;
            _repo.UndeleteCountries();
            LoadCountries();
            _currentIndex = _countries.FindIndex(c => c.Country.Name == name);
        }

        private void LoadCountries()
        {
            var listOfCountries = _repo.LoadCountries();
            _countries.Clear();
            foreach (var dto in listOfCountries)
            {
                var country = new Country
                {
                    Name = dto.Name,
                    Flag = dto.Flag,
                    Capital = dto.Capital,
                    Description = dto.Description
                };
                var persisted = new PersistedCountry
                {
                    Country = country,
                    IsDeleted = dto.Deleted
                };
                _countries.Add(persisted);
            }
        }
    }
}
