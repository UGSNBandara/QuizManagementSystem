using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MasterLogin {
    public class MasterLogin
    {
        private List<(string Username, string Password)> users = new List<(string, string)>();

        public void LoadUsersFromDatabase()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sulit\\Documents\\loginData.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT username, password FROM admin";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader.GetString(0); // username column
                            string password = reader.GetString(1); // password column
                            users.Add((username, password));
                        }
                    }
                }
            }

            public bool SignUp(string username, string password)
            {
                // Check if username already exists
                foreach (var user in users)
                {
                    if (user.Username == username)
                    {
                        return false; // Username is taken
                    }
                }

                // Add to in-memory list
                users.Add((username, password));

                // Save to database
                string connectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulit\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30";
                string query = "INSERT INTO admin (username, password) VALUES (@username, @password)";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); // Remember to hash the password
                        command.ExecuteNonQuery();
                    }
                }

                return true; // Sign-up successful
            }
        }


    }
}
