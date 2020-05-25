using CountriesControlData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesControlData.Implementations
{
    public class CountryRepository : ICountryRepository
    {
        public List<CountryDTO> LoadCountries()
        {
            var listOfCountries = new List<CountryDTO>();
            using (var connection = SqlQueries.SimpleDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlQueries.LoadCountries;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var country = new CountryDTO
                        {
                            Name = reader.GetString(0),
                            Flag = reader.GetString(1),
                            Capital = reader.GetString(2),
                            Description = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            Deleted = reader.GetBoolean(4)
                        };
                        listOfCountries.Add(country);
                    }
                }
            }

            return listOfCountries;
        }

        public void UpdateCountryDescription(string name, string description)
        {
            using (var connection = SqlQueries.SimpleDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlQueries.UpdateDescription;
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCountry(string name)
        {
            using (var connection = SqlQueries.SimpleDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlQueries.DeleteCountry;
                    command.Parameters.AddWithValue("@Name", name);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UndeleteCountries()
        {
            using (var connection = SqlQueries.SimpleDbConnection())
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = SqlQueries.UndeleteCountries;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
