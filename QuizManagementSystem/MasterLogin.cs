using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QuizManagementSystem
{
    public class MasterLogin
    {
        private Dictionary<string, UserDetails> users = new Dictionary<string, UserDetails>();

        public MasterLogin()
        {
            SignUp("Admin", "admin@example.com", "admin", "admin123");
        }

        public bool SignUp(string name, string email, string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return false;
            }
            

            UserDetails newUser = new UserDetails
            {
                Name = name,
                Email = email,
                UserName = username,
                Password = password,
            };

            users.Add(username, newUser);
            return true;
        }

        public bool CheckCredentials(string username, string password)
        {
            if (users.TryGetValue(username, out UserDetails user))
            {
                return user.Password == password;
            }

            return false;
        }

        public List<UserDetails> GetAllUsers()
        {
            return new List<UserDetails>(users.Values);
        }

    }

    public class UserDetails
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
