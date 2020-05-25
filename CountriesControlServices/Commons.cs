using CountriesControlData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlServices
{
    public class Commons
    {
        public static string ProjectDirectory = SqlQueries.ProjectDirectory;
        public static string FlagsPath = Path.Combine(SqlQueries.ProjectDirectory, "Flags");
    }
}
