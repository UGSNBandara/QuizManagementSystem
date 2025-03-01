using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuizManagementSystem.Data_Structures.PlayeBinaryPlusLinkedList;

namespace QuizManagementSystem.Data_Structures
{
    public class MasterAVLTree
    {
        public class AVLTreeNode
        {
            public Master master { get; set; }
            public AVLTreeNode Left { get; set; }
            public AVLTreeNode Right { get; set; }
            public int Height { get; set; }
        

            public AVLTreeNode(Master newmaster)
            {
                master = newmaster;
                Left = null;
                Right = null;
                Height = 1;
            }
        }


        private AVLTreeNode root;

        public MasterAVLTree()
        {
            root = null;
        }

        //to add, this function call the next Add function with root and username,
        //from outside cannot access the root (since it is private) thats why here use 2 function
        public void Add(Master newmaster)
        {
            root = Add(root, newmaster);
        }

        private AVLTreeNode Add(AVLTreeNode node, Master newmaster)
        {
            //first half same as the BST tree
            if (node == null)
            {
                return new AVLTreeNode(newmaster);
            }

            int comparison = newmaster.UserName.CompareTo(node.master.UserName);

            if (comparison < 0)
            {
                node.Left = Add(node.Left, newmaster);
            }
            else if (comparison > 0)
            {
                node.Right = Add(node.Right, newmaster);
            }
            else
            {
                return node; // this will not allow duplicates, if the comparison is 0, it will not add it and return the node
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // if left side is hihger, (balance > 1) 
            if (balance > 1  &&  newmaster.UserName.CompareTo(node.Left.master.UserName)<0 )
            {
                return RightRotate(node);
            }

            // if right side is higer, (balance < -1)
            if (balance < -1 && newmaster.UserName.CompareTo(node.Right.master.UserName) > 0)
            {
                return LeftRotate(node);
            }

            //if the left side is higer and the Left side node key is less than the new key
            if (balance > 1 && newmaster.UserName.CompareTo(node.Left.master.UserName) > 0 )
            {
                node.Left = LeftRotate(node.Left); //do the left rotation to the left subtree
                return RightRotate(node);
            }

            //if the right side is higer and the Right side node key is less than the new key
            if (balance < -1 && newmaster.UserName.CompareTo(node.Right.master.UserName) < 0)
            {
                node.Right = RightRotate(node.Right); //do the right rotation to the right sub tree
                return LeftRotate(node);
            }

            return node; 
        }

        private int GetHeight(AVLTreeNode node)
        {
            return node == null ? 0 : node.Height;
        }

        private int GetBalance(AVLTreeNode node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }

        //I have use l - left side node, r - right side node
        // n - current node
        // ll - left node of left side node
        // rr - rigth node of right side node
        // Right rotation
        private AVLTreeNode RightRotate(AVLTreeNode n)
        {
            AVLTreeNode l = n.Left;
            AVLTreeNode lr = l.Right;

            // rotation, as the diagram int he short note
            l.Right = n;
            n.Left = lr;

            // Update heights of the changed root
            n.Height = Math.Max(GetHeight(n.Left), GetHeight(n.Right)) + 1;
            l.Height = Math.Max(GetHeight(l.Left), GetHeight(l.Right)) + 1;

            // Return the current root on sub tree, this is for come to the Main root at the end
            return l;
        }

        // Left rotation
        private AVLTreeNode LeftRotate(AVLTreeNode n)
        {
            AVLTreeNode r = n.Right;
            AVLTreeNode rl = r.Left;

            r.Left = n;
            n.Right = rl;

            // Update heights of the changed root
            n.Height = Math.Max(GetHeight(n.Left), GetHeight(n.Right)) + 1;
            r.Height = Math.Max(GetHeight(r.Left), GetHeight(r.Right)) + 1;

            return r;
        }

        public AVLTreeNode Delete(AVLTreeNode node, string username)
        {

            if (node == null)
                return node;

            int comparison = username.CompareTo(node.master.UserName);
            if (comparison<0)
                node.Left = Delete(node.Left, username);
            else if (comparison > 0)
                node.Right = Delete(node.Right, username);
            else
            {
                // Node with only one child or no child
                if ((node.Left == null) || (node.Right == null))
                {
                    AVLTreeNode temp = node.Left ?? node.Right;

                    if (temp == null)
                    {
                        temp = node;
                        node = null;
                    }
                    else
                        node = temp;

                    temp = null;
                }
                else
                {
                    //Same as we did in the BST
                    AVLTreeNode temp = GetMinValueNode(node.Right);
                    node.master = temp.master;

                    node.Right = Delete(node.Right, temp.master.UserName);
                }
            }

            if (node == null)
            {
                return node; // when the relevent user name not exist
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // Left-Left Case
            if (balance > 1 && GetBalance(node.Left) >= 0)
                return RightRotate(node);

            // Left-Right Case
            if (balance > 1 && GetBalance(node.Left) < 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right-Right Case
            if (balance < -1 && GetBalance(node.Right) <= 0)
                return LeftRotate(node);

            // Right-Left Case
            if (balance < -1 && GetBalance(node.Right) > 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }


        private AVLTreeNode GetMinValueNode(AVLTreeNode node)
        {
            AVLTreeNode current = node;

            while (current.Left != null)
                current = current.Left;

            return current;
        }

        public Master Search(string username)
        {
            return Search(root, username)?.master;
        }

        private AVLTreeNode Search(AVLTreeNode node, string username)
        {
            if(node == null)
            {
                return null; // no such a user name exist
            }

            int comparison = username.CompareTo(node.master.UserName);

            if(comparison == 0)
            {
                return node;
            }
            else if (comparison < 0)
            {
                return Search(node.Left, username);
            }
            else if (comparison > 0)
            {
                return Search(node.Right, username);
            }

            return node;
        }
    }

}
