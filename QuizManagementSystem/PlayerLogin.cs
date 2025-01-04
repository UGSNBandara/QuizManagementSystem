using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QuizManagementSystem
{
    public class PlayerLogin
    {

        private Dictionary<string, PlayerDetails> players = new Dictionary<string, PlayerDetails>();

        public PlayerLogin()
        {

            SignUp("Player1", "player1@example.com", "player1", "player123");
        }

        public bool SignUp(string name, string email, string username, string password)
        {
            if (players.ContainsKey(username))
            {
                return false;
            }


            PlayerDetails newPlayer = new PlayerDetails()
            {
                Name = name,
                Email = email,
                UserName = username,
                Password = password
            };

            players.Add(username, newPlayer);
            return true;
        }

        public bool CheckCredentials(string username, string password)
        {
            if (players.TryGetValue(username, out PlayerDetails player))
            {
                return player.Password == password;
            }

            return false;
        }

        public List<PlayerDetails> GetAllPlayers()
        {
            return new List<PlayerDetails>(players.Values);
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

    public class PlayerDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }

}