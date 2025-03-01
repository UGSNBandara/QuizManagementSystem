using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Data_Structures
{
    public class MasterBinaryTreeSearch
    {
        public MasterBinaryTreeSearch()
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
}
