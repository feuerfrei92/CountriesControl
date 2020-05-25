using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlData
{
    public class SqlQueries
    {
        public static string ProjectDirectory
        {
            get { return Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName; }
        }

        public static string DbFile
        {
            get { return Path.Combine(ProjectDirectory, "Countries.db"); }
        }

        public static SQLiteConnection SimpleDbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }

        public static string LoadCountries
        {
            get { return "SELECT * FROM Country WHERE Deleted = 0"; }
        }

        public static string UpdateDescription
        {
            get { return "UPDATE Country SET Description = @Description WHERE Name = @Name"; }
        }

        public static string DeleteCountry
        {
            get { return "UPDATE Country SET Deleted = 1 WHERE Name = @Name"; }
        }

        public static string UndeleteCountries
        {
            get { return "UPDATE Country SET Deleted = 0 WHERE Deleted = 1"; }
        }
    }
}
