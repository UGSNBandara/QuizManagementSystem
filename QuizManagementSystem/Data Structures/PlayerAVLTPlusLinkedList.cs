using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuizManagementSystem.Data_Structures.MasterAVLTree;

namespace QuizManagementSystem.Data_Structures
{
    public class PlayerAVLTPlusLinkedList
    {
        public PlayerAVLTPlusLinkedList()
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

            public int Height { get; set; }

            public Node(Player player)
            {
                Player = player;
                Left = null;
                Right = null;
                Prev = null;
                Next = null;
                Height = 1;
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
            if (node == null)
            {
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

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            int balance = GetBalance(node);

            // if left side is hihger, (balance > 1) 
            if (balance > 1 && player.Username.CompareTo(node.Left.Player.Username) < 0)
            {
                return RightRotate(node);
            }

            // if right side is higer, (balance < -1)
            if (balance < -1 && player.Username.CompareTo(node.Right.Player.Username) > 0)
            {
                return LeftRotate(node);
            }

            //if the left side is higer and the Left side node key is less than the new key
            if (balance > 1 && player.Username.CompareTo(node.Left.Player.Username) > 0)
            {
                node.Left = LeftRotate(node.Left); //do the left rotation to the left subtree
                return RightRotate(node);
            }

            //if the right side is higer and the Right side node key is less than the new key
            if (balance < -1 && player.Username.CompareTo(node.Right.Player.Username) < 0)
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

        public void UpdateScore(string username, double marks)
        {
            UpdateScore(Root, username, marks);
        }

        public void UpdateScore(Node node, string username, double marks)
        {
            int comparison = username.CompareTo(node.Player.Username);

            if (comparison == 0)
            {
                node.Player.Score = marks;
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


        private Node FindMin(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }

        public IEnumerable<Player> ReturnPlayersInOder()
        {
            //Sort();
            //InSort();
            MSort();
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

        //Insertion sort
        public void InSort()
        {
            if (head == null || head.Next == null)
            {
                return;
            }

            Node sorted = null;
            Node current = head;

            while (current != null)
            {
                Node next = current.Next;


                if (sorted == null || sorted.Player.Score <= current.Player.Score)
                {

                    current.Next = sorted;
                    if (sorted != null)
                    {
                        sorted.Prev = current;
                    }
                    sorted = current;
                    sorted.Prev = null;
                }
                else
                {

                    Node temp = sorted;
                    while (temp.Next != null && temp.Next.Player.Score > current.Player.Score)
                    {
                        temp = temp.Next;
                    }


                    current.Next = temp.Next;
                    if (temp.Next != null)
                    {
                        temp.Next.Prev = current;
                    }
                    temp.Next = current;
                    current.Prev = temp;
                }

                current = next;
            }

            head = sorted;
        }

        public void MSort()
        {
            if (head == null || head.Next == null)
            {
                return;
            }
            head = MergeSort(head);
        }

        private Node MergeSort(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node middle = GetMiddle(head);
            Node nextToMiddle = middle.Next;
            middle.Next = null;
            if (nextToMiddle != null)
            {
                nextToMiddle.Prev = null;
            }

            Node left = MergeSort(head);
            Node right = MergeSort(nextToMiddle);

            return Merge(left, right);
        }

        private Node GetMiddle(Node head)
        {
            if (head == null)
            {
                return head;
            }

            Node slow = head, fast = head;
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        private Node Merge(Node left, Node right)
        {
            if (left == null)
            {
                return right;
            }
            if (right == null)
            {
                return left;
            }

            Node result;
            if (left.Player.Score > right.Player.Score)
            {
                result = left;
                result.Next = Merge(left.Next, right);
                if (result.Next != null)
                {
                    result.Next.Prev = result;
                }
            }
            else
            {
                result = right;
                result.Next = Merge(left, right.Next);
                if (result.Next != null)
                {
                    result.Next.Prev = result;
                }
            }

            result.Prev = null;
            return result;
        }
    }
}
