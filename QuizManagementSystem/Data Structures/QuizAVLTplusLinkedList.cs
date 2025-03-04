using QuizManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Data_Structures
{
    public class QuizAVLTplusLinkedList
    {
        private class Node
        {
            public int Key { get; set; }
            public Quiz Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public int Height { get; set; }


            public Node(int key, Quiz value)
            {
                Key = key;
                Value = value;
                Left = null;
                Right = null;
                Prev = null;
                Next = null;
                Height = 1;
            }
        }

        public QuizAVLTplusLinkedList()
        {
            root = null;
            head = null;
        }

        private Node root;
        private Node head;

        public void Insert(int key, Quiz value)
        {
            root = Insert(root, key, value);
        }


        private Node Insert(Node node, int key, Quiz value)
        {
            if (node == null)
            {
                Node newNode = new Node(key, value);
                UpdateLinkedList(newNode);
                return newNode;
            }

            int comparison = key.CompareTo(node.Key);
            if (comparison < 0)
            {
                node.Left = Insert(node.Left, key, value);
            }
            else if (comparison > 0)
            {
                node.Right = Insert(node.Right, key, value);
            }
            else
            {
                node.Value = value;
            }

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // if left side is hihger, (balance > 1) 
            if (balance > 1 && key.CompareTo(node.Left.Key) < 0)
            {
                return RightRotate(node);
            }

            // if right side is higer, (balance < -1)
            if (balance < -1 && key.CompareTo(node.Right.Key) > 0)
            {
                return LeftRotate(node);
            }

            //if the left side is higer and the Left side node key is less than the new key
            if (balance > 1 && key.CompareTo(node.Left.Key) > 0)
            {
                node.Left = LeftRotate(node.Left); //do the left rotation to the left subtree
                return RightRotate(node);
            }

            //if the right side is higer and the Right side node key is less than the new key
            if (balance < -1 && key.CompareTo(node.Right.Key) < 0)
            {
                node.Right = RightRotate(node.Right); //do the right rotation to the right sub tree
                return LeftRotate(node);
            }

            return node;
        }



        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        private int GetBalance(Node node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }

        //I have use l - left side node, r - right side node
        // n - current node
        // ll - left node of left side node
        // rr - rigth node of right side node
        // Right rotation
        private Node RightRotate(Node n)
        {
            Node l = n.Left;
            Node lr = l.Right;

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
        private Node LeftRotate(Node n)
        {
            Node r = n.Right;
            Node rl = r.Left;

            r.Left = n;
            n.Right = rl;

            // Update heights of the changed root
            n.Height = Math.Max(GetHeight(n.Left), GetHeight(n.Right)) + 1;
            r.Height = Math.Max(GetHeight(r.Left), GetHeight(r.Right)) + 1;

            return r;
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

            while (current != null && current.Value.Marks > newNode.Value.Marks)
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

        public int FindMaxID()
        {
            if (root == null) throw new InvalidOperationException("The tree is empty.");
            Node max = FindMax(root);
            return max.Key;
        }

        private Node FindMax(Node node)
        {
            if (node == null) return null;
            while (node.Right != null) node = node.Right;
            return node;
        }

        // this ok
        public void Remove(int key)
        {
            root = Remove(root, key);
        }

        //this ok
        private Node Remove(Node node, int key)
        {
            if (node == null) return null;

            int comparison = key.CompareTo(node.Key);
            if (comparison < 0)
            {
                node.Left = Remove(node.Left, key);
            }
            else if (comparison > 0)
            {
                node.Right = Remove(node.Right, key);
            }
            else
            {
                // Update the linked list pointers
                if (node.Prev != null) node.Prev.Next = node.Next;
                if (node.Next != null) node.Next.Prev = node.Prev;

                // Update the tree structure
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                Node temp = FindMin(node.Right);
                node.Key = temp.Key;
                node.Value = temp.Value;
                node.Right = Remove(node.Right, temp.Key);
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


        //this ok
        private Node FindMin(Node node)
        {
            if (node == null) return null;
            while (node.Left != null) node = node.Left;
            return node;
        }

        public Quiz Search(int key)
        {
            Node node = Search(root, key);
            if (node == null) throw new KeyNotFoundException("Key not found in the tree.");
            return node.Value;
        }

        private Node Search(Node node, int key)
        {
            if (node == null || key.CompareTo(node.Key) == 0) return node;

            if (key.CompareTo(node.Key) < 0) return Search(node.Left, key);

            return Search(node.Right, key);
        }


        public IEnumerable<Quiz> GetQuizzesInLinkedListOrder()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        //This return the relevent question list by quizID
        public List<Question> GetQuestionsByQuizID(int quizID)
        {
            Quiz quiz = Search(quizID);
            if (quiz == null)
            {
                throw new KeyNotFoundException($"Quiz with ID {quizID} not found.");
            }
            return quiz.Questions;
        }


    }
}