using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlData
{
    public class CountryDTO
    {
        public string Flag { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}
