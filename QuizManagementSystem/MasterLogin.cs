using System;
using System.Collections.Generic;
using QuizManagementSystem.Data_Structures;
using QuizManagementSystem.MongoFiles;

namespace QuizManagementSystem
{
    public class MasterLogin
    {
        //private MasterBinaryTreeSearch MasterDS;
        private MasterAVLTree MasterDS;
        private MasterMongo masterMongo;

        public MasterLogin()
        {
            //MasterDS = new MasterBinaryTreeSearch();
            MasterDS = new MasterAVLTree();
            masterMongo = new MasterMongo();
            List <Master> masters = new List<Master>();
            masters = masterMongo.GetAllPlayers();

            foreach (Master x in masters)
            {
                MasterDS.Add(x);    
            }

        }

        public bool SignUp(string name, string email, string username, string password)
        {
            Master master = MasterDS.Search(username);
            if (master != null)
            {
                return false;
            }

            Master newUser = new Master
            {
                Name = name,
                Email = email,
                UserName = username,
                Password = password,
            };

            MasterDS.Add(newUser);
            masterMongo.AddMaster(newUser);

            return true;
        }

        public bool CheckCredentials(string username, string password)
        {
            Master user = MasterDS.Search(username);
            if (user != null)
            {
                return user.Password == password;
            }

            return false;
        }

        public Master GetUser(string username)
        {
            return MasterDS.Search(username);
        }

    }

    public class Master
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
