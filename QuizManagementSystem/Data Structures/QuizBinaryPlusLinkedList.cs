﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Data_Structures
{
    public class QuizBinaryPlusLinkedList
    {
        private class Node
        {
            public int Key { get; set; }
            public Quiz Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }



            public Node(int key, Quiz value)
            {
                Key = key;
                Value = value;
            }
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

            return node;
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
