using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlData.Interfaces
{
    public interface ICountryRepository
    {
        List<CountryDTO> LoadCountries();
        void UpdateCountryDescription(string name, string description);
        void DeleteCountry(string name);
        void UndeleteCountries();
    }
}
