using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace QuizManagementSystem
{
    public class PlayerLogin
    {
        private List<(string Username, string Password)> player = new List<(string, string)>();

        public void LoadPlayersFormDatabase()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sulit\\Documents\\loginData.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT username, password FROM player";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = reader.GetString(0); 
                            string password = reader.GetString(1); 
                            player.Add((username, password));
                        }
                    }
                }
            }
        }

        public bool CheckCredentials(string username, string password)
        {
            foreach (var user in player)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool SignUp(string name, string email, string username, string password)
        {
            foreach (var user in player)
            {
                if (user.Username == username)
                {
                    return false;
                }
            }

            player.Add((username, password));

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sulit\\Documents\\loginData.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "INSERT INTO player (name, email, username, password) VALUES (@name, @email, @username, @password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
