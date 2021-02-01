using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using C969.DBItems;

namespace C969 {
    public static class DBManager {
        #region Generic MySQL Access Functions
        /// <summary>
        /// Inserts new record into specified TABLE using the provided VALUES
        /// </summary>
        /// <param name="table">Tables to apply the new record</param>
        /// <param name="values">Values parameters to apply, usually in the form of a seires of 'columnName = value', separated by commas</param>
        /// <returns></returns>
        public static int InsertNewRecord(string table, string values) {
            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);

            // Build the Query to Run
            StringBuilder insertQueryBuilder = new StringBuilder();
            insertQueryBuilder.Append($"INSERT INTO {table} VALUES ({values});");
            string query = insertQueryBuilder.ToString();

            MySqlCommand insertCommand = new MySqlCommand(query, dbConnection);

            // Attempt to run the query against the database, and return the number of rows affected
            try {
                dbConnection.Open();
                return insertCommand.ExecuteNonQuery();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Update MySql TABLE with provided QUERY. Returns number of rows affected.
        /// </summary>
        /// <param name="table">Table in Database to apply query</param>
        /// <param name="values">Values portion of MySql Query, usually a series of 'columnName = valueName' separated by commas</param>
        /// <param name="where">MySQL WHERE filter used to determine what records are affected, usually in the form of 'id = 1' or similar</param>
        /// <returns></returns>
        public static int UpdateRecord(string table, string values, string where = "") {
            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);

            StringBuilder updateQueryBuilder = new StringBuilder();
            updateQueryBuilder.Append($"UPDATE {table} SET {values}");
            if(where != "") {
                updateQueryBuilder.Append($" WHERE {where};");
            }
            else {
                updateQueryBuilder.Append(";");
            }

            string query = updateQueryBuilder.ToString();

            MySqlCommand updateCommand = new MySqlCommand(query, dbConnection);

            // Attempt to run the query against the database, and return the number of rows affected
            try {
                dbConnection.Open();
                return updateCommand.ExecuteNonQuery();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Removes records from specified TABLE using the provided WHERE filter
        /// </summary>
        /// <param name="table">Table to remove records from</param>
        /// <param name="where">Where filter used to determine what records are removed, usually in the form of 'id = 1' or similar</param>
        /// <returns></returns>
        public static int DeleteRecord(string table, string where) {
            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);

            StringBuilder deleteQueryBuilder = new StringBuilder();
            deleteQueryBuilder.Append($"DELETE FROM {table} WHERE {where};");

            string query = deleteQueryBuilder.ToString();

            MySqlCommand deleteCommand = new MySqlCommand(query, dbConnection);

            // Attempt to run the query against the database, and return the number of rows affected
            try {
                dbConnection.Open();
                return deleteCommand.ExecuteNonQuery();
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally {
                dbConnection.Close();
            }
        }
        #endregion

        #region Database Data Retrieval Functions
        /// <summary>
        /// Retrieves most current list of records in USER table of Database
        /// </summary>
        /// <returns>List of UserAccount objects</returns>
        public static List<UserAccount> GetAllUserAccounts() {
            List<UserAccount> allUsers = new List<UserAccount>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allUsersQuery = "SELECT * FROM user";
            MySqlCommand selectAllUsersCommand = new MySqlCommand(allUsersQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectAllUsersCommand.ExecuteReader();

                while(reader.Read()) {
                    UserAccount user = new UserAccount(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5));
                    allUsers.Add(user);
                }

                return allUsers;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Retrieves most current list of records in APPOINTMENT table of Database
        /// </summary>
        /// <returns>List of Appointment objects</returns>
        public static List<Appointment> GetAllAppointments() {
            List<Appointment> allAppointments = new List<Appointment>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allAppointmentsQuery = "SELECT * FROM appointment";
            MySqlCommand selectAllAppointmentsCommand = new MySqlCommand(allAppointmentsQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectAllAppointmentsCommand.ExecuteReader();

                while(reader.Read()) {
                    Appointment appointment = new Appointment(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                        reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetDateTime(10), reader.GetDateTime(11), reader.GetString(12), reader.GetDateTime(13), reader.GetString(14));

                    allAppointments.Add(appointment);
                }

                return allAppointments;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Retrieves most current list of records in CUSTOMER table of Database
        /// </summary>
        /// <returns>List of Customer objects</returns>
        public static List<Customer> GetAllCustomers() {
            List<Customer> allCustomers = new List<Customer>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allCustomersQuery = "SELECT * FROM customer";
            MySqlCommand selectCustomersCommand = new MySqlCommand(allCustomersQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectCustomersCommand.ExecuteReader();

                while(reader.Read()) {
                    Customer customer = new Customer(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetBoolean(3), reader.GetDateTime(4), reader.GetString(5),
                        reader.GetDateTime(6), reader.GetString(7));

                    allCustomers.Add(customer);
                }

                return allCustomers;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Retrieves most current list of records in ADDRESS table of Database
        /// </summary>
        /// <returns>List of Address objects</returns>
        public static List<Address> GetAllAddresses() {
            List<Address> allAddresses = new List<Address>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allAddressesQuery = "SELECT * FROM address";
            MySqlCommand selectAddressesCommand = new MySqlCommand(allAddressesQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectAddressesCommand.ExecuteReader();

                while(reader.Read()) {
                    Address address = new Address(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6),
                        reader.GetString(7), reader.GetDateTime(8), reader.GetString(9));

                    allAddresses.Add(address);
                }

                return allAddresses;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Retrieves most current list of records in CITY table of Database
        /// </summary>
        /// <returns>List of City objects</returns>
        public static List<City> GetAllCities() {
            List<City> allCities = new List<City>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allCitiesQuery = "SELECT * FROM city";
            MySqlCommand selectCitiesCommand = new MySqlCommand(allCitiesQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectCitiesCommand.ExecuteReader();

                while(reader.Read()) {
                    City city = new City(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetString(4), reader.GetDateTime(5), reader.GetString(6));

                    allCities.Add(city);
                }

                return allCities;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        /// <summary>
        /// Retrieves most current list of records in COUNTRY table of Database
        /// </summary>
        /// <returns>List of Country objects</returns>
        public static List<Country> GetAllCountries() {
            List<Country> allCountries = new List<Country>();

            MySqlConnection dbConnection = new MySqlConnection(Settings.DBConnectionString);
            string allCountriesQuery = "SELECT * FROM country";
            MySqlCommand selectCountriesCommand = new MySqlCommand(allCountriesQuery, dbConnection);

            try {
                dbConnection.Open();

                MySqlDataReader reader = selectCountriesCommand.ExecuteReader();

                while(reader.Read()) {
                    Country country = new Country(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5));

                    allCountries.Add(country);
                }

                return allCountries;
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally {
                dbConnection.Close();
            }
        }
        #endregion
    }
}
