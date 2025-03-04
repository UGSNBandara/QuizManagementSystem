using QuizManagementSystem.Data_Structures;
using QuizManagementSystem.MongoFiles;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizManagementSystem
{
    public class PlayerLogin
    {
        //private PlayeBinaryPlusLinkedList PlayerDS;
        private PlayerAVLTPlusLinkedList PlayerDS;
        PlayerMongo plMongo = new PlayerMongo();
        public PlayerLogin()
        {
            //PlayerDS = new PlayeBinaryPlusLinkedList();
            PlayerDS = new PlayerAVLTPlusLinkedList();
            PlayerMongo plMongo = new PlayerMongo();
            
            List<Player> players = new List<Player>();
            players = plMongo.GetAllPlayers();

            foreach (Player x in players)
            {
                PlayerDS.AddPlayer(x);
            }
            
        }

        public void AddPlayer(string username, string name, double score, string email, string password)
        {
            Player newPlayer = new Player(username, name, score, email, password);
            plMongo.AddPlayer(newPlayer);
            PlayerDS.AddPlayer(newPlayer);
        }

        public bool SignUp(string name, string email, string username, string password)
        {
            Player player = PlayerDS.SearchPlayer(username);
            if (player != null)
            {
                return false;
            }
            else
            {
                Player newPlayer = new Player(username, name, 0, email, password);
                PlayerDS.AddPlayer(newPlayer);
                plMongo.AddPlayer(newPlayer);
                return true;
            }
        }

        public Player GetPlayer(string username)
        {
            Player player = PlayerDS.SearchPlayer(username);
            if (player == null)
                throw new KeyNotFoundException("Player not found.");
            return player;
        }

        public void DeletePlayer(string username)
        {
            PlayerDS.DeletePlayer(username);
        }

        public bool CheckCredentials(string username, string password)
        {
            Player player = PlayerDS.SearchPlayer(username);
            if (player == null)
            {
                return false;
            }

            if (player.Password == password)
            {
                return true;
            }

            return false;
        }

        public void UpdateScore(string username, double updatedMarks)
        {
            PlayerDS.UpdateScore(username, updatedMarks);
            plMongo.UpdateScore(username, updatedMarks);
        }


        public IEnumerable<Player> GetPlayersInOder()
        {
            return PlayerDS.ReturnPlayersInOder();
        }

    }

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