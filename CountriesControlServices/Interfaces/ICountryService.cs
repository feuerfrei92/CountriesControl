using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlServices.Interfaces
{
    public interface ICountryService
    {
        Country RefreshCurrentCountry();
        Country GetNextCountry();
        Country GetPreviousCountry();
        void ChangeDescription(string name, string description);
        void DeleteCountry(string name);
        void RestoreDeletedCountries();
    }
}
