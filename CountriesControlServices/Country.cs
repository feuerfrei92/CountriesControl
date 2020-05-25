using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlServices
{
    public class Country
    {
        public string Flag { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Description { get; set; }
    }

    public class PersistedCountry
    {
        public Country Country { get; set; }
        public bool IsDeleted { get; set; }
    }
}
