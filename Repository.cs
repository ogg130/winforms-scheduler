using MySql.Data.MySqlClient;
using RobertOgden.Data.Models;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace RobertOgden
{
    public static class Repository
    {
        public static void CreateAddress(Address address)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO address (addressId, address," +
                $" address2, cityId, postalCode, phone, createDate, createdBy, " +
                $"lastUpdate, lastUpdateBy)" +
                $"Values (@param1, @param2, @param3, @param4, @param5, @param6, " +
                $"@param7, @param8, @param9, @param10)";

            // Define params
            command.Parameters.AddWithValue("@param1", address.AddressId);
            command.Parameters.AddWithValue("@param2", address.Address1);
            command.Parameters.AddWithValue("@param3", address.Address2);
            command.Parameters.AddWithValue("@param4", address.CityId);
            command.Parameters.AddWithValue("@param5", address.PostalCode);
            command.Parameters.AddWithValue("@param6", address.Phone);
            command.Parameters.AddWithValue("@param7", SharedUtils.FormatSqlDateTime(address.CreateDate));
            command.Parameters.AddWithValue("@param8", address.CreatedBy);
            command.Parameters.AddWithValue("@param9", SharedUtils.FormatSqlDateTime(address.LastUpdate));
            command.Parameters.AddWithValue("@param10", address.LastUpdateBy);

            // Excute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void CreateAppointment(Appointment appointment)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO appointment (appointmentId, customerId, " +
            $"userId, title, description, location, contact, type, url, start, " +
            $"end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
            $"Values (@param1, @param2, @param3, @param4, @param5, @param6, @param7, " +
            $"@param8, @param9, @param10, @param11, @param12, @param13, @param14, @param15)";

            // Define params
            command.Parameters.AddWithValue("@param1", appointment.AppointmentId);
            command.Parameters.AddWithValue("@param2", appointment.CustomerId);
            command.Parameters.AddWithValue("@param3", appointment.UserId);
            command.Parameters.AddWithValue("@param4", appointment.Title);
            command.Parameters.AddWithValue("@param5", appointment.Description);
            command.Parameters.AddWithValue("@param6", appointment.Location);
            command.Parameters.AddWithValue("@param7", appointment.Contact);
            command.Parameters.AddWithValue("@param8", appointment.Type);
            command.Parameters.AddWithValue("@param9", appointment.Url);
            command.Parameters.AddWithValue("@param10", SharedUtils.FormatSqlDateTime(appointment.Start));
            command.Parameters.AddWithValue("@param11", SharedUtils.FormatSqlDateTime(appointment.End));
            command.Parameters.AddWithValue("@param12", SharedUtils.FormatSqlDateTime(appointment.CreateDate));
            command.Parameters.AddWithValue("@param13", appointment.CreatedBy);
            command.Parameters.AddWithValue("@param14", SharedUtils.FormatSqlDateTime(appointment.LastUpdate));
            command.Parameters.AddWithValue("@param15", appointment.LastUpdateBy);

            // Excute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void CreateCustomer(Customer customer)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send
            var command = connection.CreateCommand();
            command.CommandText = $"INSERT INTO customer (customerId, customerName," +
                $" addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $"Values (@param1, @param2, @param3, @param4, @param5, @param6, " +
                $"@param7, @param8)";

            // Define params
            command.Parameters.AddWithValue("@param1", customer.CustomerId);
            command.Parameters.AddWithValue("@param2", customer.CustomerName);
            command.Parameters.AddWithValue("@param3", customer.AddressId);
            command.Parameters.AddWithValue("@param4", customer.Active);
            command.Parameters.AddWithValue("@param5", SharedUtils.FormatSqlDateTime(customer.CreateDate));
            command.Parameters.AddWithValue("@param6", customer.CreatedBy);
            command.Parameters.AddWithValue("@param7", SharedUtils.FormatSqlDateTime(customer.LastUpdate));
            command.Parameters.AddWithValue("@param8", customer.LastUpdateBy);

            // Excute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateAppointment(Appointment appointment)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send using parameters to prevent
            // SQL injection amongst other reasons
            var command = connection.CreateCommand();
            command.CommandText = $"UPDATE appointment " +
                $"SET customerId = @param2, " +
                $"userId = @param3," +
                $"title = @param4, " +
                $"description = @param5, " +
                $"location = @param6, " +
                $"contact = @param7, " +
                $"type = @param8, " +
                $"url = @param9, " +
                $"start = @param10, " +
                $"end = @param11, " +
                $"createDate = @param12, " +
                $"createdBy = @param13, " +
                $"lastUpdate = @param14, " +
                $"lastUpdateBy = @param15 " +
                $"WHERE appointmentId = @param1;";

            // Set param values
            command.Parameters.AddWithValue("@param1", appointment.AppointmentId);
            command.Parameters.AddWithValue("@param2", appointment.CustomerId);
            command.Parameters.AddWithValue("@param3", appointment.UserId);
            command.Parameters.AddWithValue("@param4", appointment.Title);
            command.Parameters.AddWithValue("@param5", appointment.Description);
            command.Parameters.AddWithValue("@param6", appointment.Location);
            command.Parameters.AddWithValue("@param7", appointment.Contact);
            command.Parameters.AddWithValue("@param8", appointment.Type);
            command.Parameters.AddWithValue("@param9", appointment.Url);
            command.Parameters.AddWithValue("@param10", SharedUtils.FormatSqlDateTime(appointment.Start));
            command.Parameters.AddWithValue("@param11", SharedUtils.FormatSqlDateTime(appointment.End));
            command.Parameters.AddWithValue("@param12", SharedUtils.FormatSqlDateTime(appointment.CreateDate));
            command.Parameters.AddWithValue("@param13", appointment.CreatedBy);
            command.Parameters.AddWithValue("@param14", SharedUtils.FormatSqlDateTime(appointment.LastUpdate));
            command.Parameters.AddWithValue("@param15", appointment.LastUpdateBy);

            // Exceute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateCustomer(Customer customer)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send using parameters to prevent
            // SQL injection amongst other reasons
            var command = connection.CreateCommand();
            command.CommandText = $"UPDATE customer " +
                $"SET customerName = @param2, " +
                $"addressId = @param3," +
                $"active = @param4, " +
                $"createDate = @param5, " +
                $"createdBy = @param6, " +
                $"lastUpdate = @param7, " +
                $"lastUpdateBy = @param8 " +
                $"WHERE customerId = @param1;";

            // Set param values
            command.Parameters.AddWithValue("@param1", customer.CustomerId);
            command.Parameters.AddWithValue("@param2", customer.CustomerName);
            command.Parameters.AddWithValue("@param3", customer.AddressId);
            command.Parameters.AddWithValue("@param4", customer.Active);
            command.Parameters.AddWithValue("@param5", SharedUtils.FormatSqlDateTime(customer.CreateDate));
            command.Parameters.AddWithValue("@param6", customer.CreatedBy);
            command.Parameters.AddWithValue("@param7", SharedUtils.FormatSqlDateTime(customer.LastUpdate));
            command.Parameters.AddWithValue("@param8", customer.LastUpdateBy);

            // Exceute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void UpdateAddress(Address address)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            // Define the SQL statement to send using parameters to prevent
            // SQL injection amongst other reasons
            var command = connection.CreateCommand();
            command.CommandText = $"UPDATE address " +
                $"SET address = @param2, " +
                $"address2 = @param3," +
                $"cityId = @param4, " +
                $"postalCode = @param5, " +
                $"phone = @param6, " +
                $"createDate = @param7, " +
                $"createdBy = @param8, " +
                $"lastUpdate = @param9, " +
                $"lastUpdateBy = @param10 " +
                $"WHERE addressId = @param1;";

            // Set param values
            command.Parameters.AddWithValue("@param1", address.AddressId);
            command.Parameters.AddWithValue("@param2", address.Address1);
            command.Parameters.AddWithValue("@param3", address.Address2);
            command.Parameters.AddWithValue("@param4", address.CityId);
            command.Parameters.AddWithValue("@param5", address.PostalCode);
            command.Parameters.AddWithValue("@param6", address.Phone);
            command.Parameters.AddWithValue("@param7", SharedUtils.FormatSqlDateTime(address.CreateDate));
            command.Parameters.AddWithValue("@param8", address.CreatedBy);
            command.Parameters.AddWithValue("@param9", SharedUtils.FormatSqlDateTime(address.LastUpdate));
            command.Parameters.AddWithValue("@param10", address.LastUpdateBy);

            // Exceute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void DeleteAppointment(Appointment source)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            //Define SQL command using params
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM appointment WHERE appointmentId = @param";

            // Define params
            command.Parameters.AddWithValue("@param", source.CustomerId);

            // Execute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static MySqlConnection DeleteCustomer(Customer source)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            //Define SQL command using params
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM customer WHERE customerId = @param";

            // Define params
            command.Parameters.AddWithValue("@param", source.CustomerId);

            // Execute query, close connection
            command.ExecuteNonQuery();
            return connection;
        }

        public static void DeleteAddress(Address source)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            //Define SQL command using params
            var command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM address WHERE addressId = @param";

            // Define params
            command.Parameters.AddWithValue("@param", source.AddressId);
            // Execute query, close connection
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Method which executs a SQL SELECT statment and returns a bindingList
        public static BindingList<Appointment> PopulateAppointments()
        {
            // Create the connection
            var conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);

            try
            {
                //Open a database connection
                connection.Open();

                // Create a dynamic SQL SELECT statement and run it
                var command = new MySqlCommand($"SELECT * FROM appointment", connection);
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Fill a new Bindinglist of whatever type is passed into the method and populate it
                var records = new BindingList<Appointment>();

                // Iterate over the sql queries results
                for (var i = 0; i < dataTable.Rows.Count; ++i)
                {
                    // Add new record
                    records.Add((Appointment)Activator.CreateInstance(typeof(Appointment), new object[] { dataTable.Rows[i] }));
                }

                //Close the connection and return the bindinglist
                connection.Close();

                //I think we are supposed to add an hour for daylight svings time here

                // Iterate over records
                for (var i = 0; i < records.Count; ++i)
                {
                    // Update all dates to conform to users timezone
                    records[i].Start = Convert.ToDateTime(SharedUtils.FormatDate(records[i].Start.ToString()));
                    records[i].End = Convert.ToDateTime(SharedUtils.FormatDate(records[i].End.ToString()));
                    records[i].CreateDate = Convert.ToDateTime(SharedUtils.FormatDate(records[i].CreateDate.ToString()));
                    records[i].LastUpdate = Convert.ToDateTime(SharedUtils.FormatDate(records[i].LastUpdate.ToString()));
                }
                return records;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        /* Method which executes a SQL query and returns a bindinglist of results */

        public static BindingList<T> PopulateDefaults<T>(T record)
        {
            try
            {
                // Create and open the connection
                var conn_string = GetConnectionString();
                var connection = new MySqlConnection(conn_string);
                connection.Open();

                // Create a dynamic SQL SELECT statement and run it
                var command = new MySqlCommand($"SELECT * FROM {record.GetType().Name.ToString().ToLower()}", connection);
                var adapter = new MySqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Fill a new Bindinglist of whatever type is passed into the method and populate it
                var records = new BindingList<T>();

                // Iterate over the sql queries results
                for (var i = 0; i < dataTable.Rows.Count; ++i)
                {
                    // Add new record
                    records.Add((T)Activator.CreateInstance(typeof(T), new object[] { dataTable.Rows[i] }));
                }

                //Close the connection and return the bindinglist
                connection.Close();

                return records;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ReadReport<T>(T report)
        {
            // Create and open the connection
            string conn_string = GetConnectionString();
            var connection = new MySqlConnection(conn_string);
            connection.Open();

            var sql = "";
            if (report.GetType().Name == "Option1")
            {
                sql = "SELECT Type, MONTHNAME(start) as Month, " +
                    "YEAR(start) as Year, COUNT(appointmentId) as Appointments " +
                    "FROM appointment " +
                    "GROUP BY MONTH(start), type " +
                    "ORDER BY year, month";
            }
            if (report.GetType().Name == "Option2")
            {
                sql = "SELECT t2.username, t1.title, t1.description, t1.location, " +
                "t1.contact, t1.type, t1.url, t1.start, t1.end " +
                "FROM appointment t1 " +
                "INNER JOIN user t2 on t1.userId = t2.userId " +
                "ORDER BY t2.username;";
            }
            if (report.GetType().Name == "Option3")
            {
                sql = "SELECT t4.city, t1.title, t1.description, t1.location, " +
                "t1.contact, t1.type, t1.url, t1.start, t1.end " +
                "FROM appointment t1 " +
                "INNER JOIN customer t2 ON t1.customerId = t2.customerId " +
                "INNER JOIN address t3 ON t2.addressId = t3.addressId " +
                "INNER JOIN city t4 ON t3.cityId = t4.cityId " +
                "INNER JOIN ( " +
                "   SELECT t4.city, count(t1.appointmentid) as appointments " +
                "   FROM appointment t1 " +
                "   INNER JOIN customer t2 ON t1.customerId = t2.customerId " +
                "   INNER JOIN address t3 ON t2.addressId = t3.addressId" +
                "   INNER JOIN city t4 ON t3.cityId = t4.cityId " +
                "   GROUP BY t4.city" +
                "   ORDER BY appointments DESC " +
                "   LIMIT 1 " +
                ") AS t5 ON t5.city = t4.city " +
                "WHERE t5.city = t4.city;";
            }
            connection = new MySqlConnection(conn_string);
            connection.Open();
            // Run SQL statement and populate datatable with its results
            var adapter = new MySqlDataAdapter(sql, connection);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        }
    }
}