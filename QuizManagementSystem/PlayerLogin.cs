using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static QuizManagementSystem.BinarySearchTreeForPlayer;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizManagementSystem
{
    public class PlayerLogin
    {
        private BinarySearchTreeForPlayer PlayerDS;
        PlayerMongo plMongo = new PlayerMongo();
        public PlayerLogin()
        {
            PlayerDS = new BinarySearchTreeForPlayer();
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

        public void UpdateScore(string username, double marks)
        {
            plMongo.UpdateScore(username, marks);
            PlayerDS.UpdateScore(username, marks);
        }


        public IEnumerable<Player> GetPlayersInOder()
        {
            return PlayerDS.ReturnPlayersInOder();
        }
    }

    public class BinarySearchTreeForPlayer
    {
        public BinarySearchTreeForPlayer()
        {
            Root = null; 
        }
        public class Node
        {
            public Player Player { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(Player player)
            {
                Player = player;
                Left = null;
                Right = null;
                Prev = null;
                Next = null;
            }
        }

        private Node Root;
        private Node head;

        public void AddPlayer(Player player)
        {
            Root = AddPlayer(Root, player);
        }

        private Node AddPlayer(Node node, Player player)
        {
            if (node == null){
                Node newNode = new Node(player);
                UpdateLinkedList(newNode);
                return newNode;
            }

            int comparison = player.Username.CompareTo(node.Player.Username);

            if (comparison < 0) 
                node.Left = AddPlayer(node.Left, player);
            else if (comparison > 0) 
                node.Right = AddPlayer(node.Right, player);
            else
                throw new ArgumentException("Username must be unique.");
            return node;
        }

        public void UpdateScore(string username, double marks)
        {
            UpdateScore(Root, username, marks);
        }

        public void UpdateScore(Node node, string username, double marks)
        {
            int comparison = username.CompareTo(node.Player.Username);

            if (comparison == 0)
            {
                node.Player.Score += marks;
            }
            else if (comparison < 0)
            {
                UpdateScore(node.Left, username, marks);
            }
            else
            {
                UpdateScore(node.Right, username, marks);
            }
        }


        private void UpdateLinkedList(Node newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            Node prev = null;

            while (current != null && current.Player.Score > newNode.Player.Score)
            {
                prev = current;
                current = current.Next;
            }

            newNode.Next = current;
            newNode.Prev = prev;

            if (prev != null)
            {
                prev.Next = newNode;
            }
            else
            {
                head = newNode; 
            }

            if (current != null)
            {
                current.Prev = newNode;
            }
        }

        public Player SearchPlayer(string username)
        {
            Node result = SearchPlayer(Root, username);

            if (result == null)
            {
                return null; 
            }

            return result.Player;
        }

        private Node SearchPlayer(Node node, string username)
        {
            if (node == null) return null;

            if (username == node.Player.Username) return node;

            int comparison = username.CompareTo(node.Player.Username);

            if (comparison < 0)
            {
                return SearchPlayer(node.Left, username); 
            }
            else
            {
                return SearchPlayer(node.Right, username); 
            }

        }


        public void DeletePlayer(string username)
        {
            Root = DeletePlayer(Root, username);
        }

        private Node DeletePlayer(Node node, string username)
        {
            if (node == null) return null; 

            int comparison = username.CompareTo(node.Player.Username);

            if (comparison < 0) 
            {
                node.Left = DeletePlayer(node.Left, username);
            }
            else if (comparison > 0)
            {
                node.Right = DeletePlayer(node.Right, username);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left; 

                Node temp = FindMin(node.Right);
                node.Player = temp.Player; 

                node.Right = DeletePlayer(node.Right, temp.Player.Username);
            }

            return node;
        }


        private Node FindMin(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }

        public IEnumerable<Player> ReturnPlayersInOder()
        {
            Sort();
            Node current = head;
            while (current != null)
            {
                yield return current.Player;
                current = current.Next;
            }
        }

        //sort in decreasing oder

        public void Sort()
        {
            if (head == null || head.Next == null)
            {
                return;
            }

            bool swapped = false;

            do
            {
                swapped = false;
                Node current = head;
                Node temp = null;

                while (current != null && current.Next != null)
                {
                    if (current.Player.Score < current.Next.Player.Score)
                    {
                        if (current.Prev == null)
                        {
                            temp = current.Next;
                            current.Next = current.Next.Next;
                            temp.Next = current;
                            temp.Prev = null;
                            current.Prev = temp;
                            head = temp;
                        }
                        else
                        {
                            temp = current.Next;
                            current.Next = temp.Next;
                            temp.Next = current;
                            temp.Prev = current.Prev;
                            current.Prev.Next = temp;
                            current.Prev = temp;

                        }
                        swapped = true;
                    }

                    current = current.Next;
                }
            } while (swapped);
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