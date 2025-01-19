using System;
using System.Collections.Generic;

namespace QuizManagementSystem
{
    public class MasterLogin
    {
        private BinarySearchTreeForMaster MasterDS;

        public MasterLogin()
        {
            MasterDS = new BinarySearchTreeForMaster();
            SignUp("Admin", "admin@example.com", "admin", "admin123");
            SignUp("Admin2", "admin2@example.com", "admin2", "admin123");
            SignUp("Admin3", "admin3@example.com", "admin3", "admin123");
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

    public class BinarySearchTreeForMaster
    {
        public BinarySearchTreeForMaster()
        {
            root = null;
        }
        private class Node
        {
            public Master Master { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(Master master)
            {
                Master = master;
                Left = null;
                Right = null;
            }
        }
        private Node root;

        public void Add(Master user)
        {
            root = Add(root, user);
        }

        private Node Add(Node node, Master user)
        {
            if (node == null)
            {
                return new Node(user);
            }

            int comparison = user.UserName.CompareTo(node.Master.UserName);

            if (comparison < 0)
            {
                node.Left = Add(node.Left, user);
            }
            else if (comparison > 0)
            {
                node.Right = Add(node.Right, user);
            }

            return node;
        }

        public Master Search(string username)
        {
            return Search(root, username)?.Master;
        }

        private Node Search(Node node, string username)
        {
            if (node == null)
            {
                return null;
            }

            int comparison = username.CompareTo(node.Master.UserName);

            if (comparison == 0)
            {
                return node;
            }
            else if (comparison < 0)
            {
                return Search(node.Left, username);
            }
            else
            {
                return Search(node.Right, username);
            }
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
