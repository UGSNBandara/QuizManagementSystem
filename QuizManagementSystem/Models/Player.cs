using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{   
    public class Player
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Player(string username, string name, double score, string email, string password)
        {
            Username = username;
            Name = name;
            Score = score;
            Email = email;
            Password = password;
        }
        public Player()
        {
            Username = null;
            Name = null;
            Score = 0;
            Email = null;
            Password = null;
        }
    }
}
