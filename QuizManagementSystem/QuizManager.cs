using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace QuizManagementSystem
{
    public class QuizManager
    {
        public BinarySearchTree quizzes = new BinarySearchTree();

        public QuizManager()
        { 
            AddQuizStart(1, "Math Quiz", 100, "Dulitha");
            AddQuizStart(2, "Science Quiz", 80, "Sulitha");
            AddQuizStart(3, "History Quiz", 90, "Anusha");
            AddQuizStart(4, "Geography Quiz", 85, "Kavindu");

            AddQuestion(4, "What is the capital of Sri Lanka?", "Colombo", "Kandy", "Galle", "Jaffna", 'A');
            AddQuestion(4, "What is the capital of India?", "Mumbai", "Delhi", "Kolkata", "Chennai", 'B');
            AddQuestion(4, "What is the capital of Australia?", "Sydney", "Melbourne", "Canberra", "Brisbane", 'C');

            AddQuestion(1, "What is 3+5?", "7", "8", "9", "6", 'B');
            AddQuestion(1, "What is 15/3?", "3", "4", "5", "6", 'C');
            AddQuestion(1, "What is the square root of 49?", "6", "7", "8", "9", 'B');
            AddQuestion(1, "What is 12*3?", "36", "32", "48", "40", 'A');
            AddQuestion(1, "What is 100-25?", "80", "75", "70", "65", 'B');
            AddQuestion(1, "What is 9+10?", "19", "21", "20", "18", 'A');
            AddQuestion(1, "What is 81/9?", "7", "8", "9", "10", 'C');
            AddQuestion(1, "What is the cube of 2?", "6", "8", "9", "4", 'B');
            AddQuestion(1, "What is 16*2?", "30", "28", "32", "34", 'C');
            AddQuestion(1, "What is 99+1?", "100", "101", "99", "98", 'A');

            AddQuestion(2, "What is the chemical symbol for gold?", "Au", "Ag", "Fe", "Cu", 'A');
            AddQuestion(2, "Which planet is known as the Red Planet?", "Venus", "Mars", "Jupiter", "Saturn", 'B');
            AddQuestion(2, "What is the powerhouse of the cell?", "Nucleus", "Ribosome", "Mitochondria", "Golgi Apparatus", 'C');
            AddQuestion(2, "What is the speed of light?", "300,000 km/s", "150,000 km/s", "500,000 km/s", "100,000 km/s", 'A');
            AddQuestion(2, "What is HCl commonly known as?", "Hydrochloric Acid", "Sulfuric Acid", "Nitric Acid", "Acetic Acid", 'A');
            AddQuestion(2, "Which gas is most abundant in Earth's atmosphere?", "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen", 'B');
            AddQuestion(2, "Who developed the theory of relativity?", "Isaac Newton", "Albert Einstein", "Galileo Galilei", "Nikola Tesla", 'B');
            AddQuestion(2, "What is the largest organ in the human body?", "Heart", "Skin", "Liver", "Brain", 'B');
            AddQuestion(2, "Which element has the atomic number 1?", "Helium", "Oxygen", "Hydrogen", "Nitrogen", 'C');
            AddQuestion(2, "What is the boiling point of water?", "0°C", "50°C", "100°C", "200°C", 'C');

            AddQuestion(3, "Who was the first President of the USA?", "George Washington", "Abraham Lincoln", "Thomas Jefferson", "John Adams", 'A');
            AddQuestion(3, "When did World War II end?", "1945", "1940", "1950", "1939", 'A');
            AddQuestion(3, "Who discovered America?", "Christopher Columbus", "Vasco da Gama", "Marco Polo", "Ferdinand Magellan", 'A');
            AddQuestion(3, "What was the name of the ship on which the Pilgrims traveled to America?", "Mayflower", "Santa Maria", "Victoria", "Endeavour", 'A');
            AddQuestion(3, "Who was the first Emperor of Rome?", "Julius Caesar", "Augustus", "Nero", "Tiberius", 'B');
            AddQuestion(3, "Which country built the Great Wall?", "China", "Japan", "India", "Korea", 'A');
            AddQuestion(3, "What was the ancient Egyptian writing system called?", "Hieroglyphics", "Cuneiform", "Runes", "Latin", 'A');
            AddQuestion(3, "Who wrote the Declaration of Independence?", "George Washington", "Benjamin Franklin", "Thomas Jefferson", "John Adams", 'C');
            AddQuestion(3, "What year did the Titanic sink?", "1910", "1912", "1914", "1918", 'B');
            AddQuestion(3, "What was the capital of the Byzantine Empire?", "Rome", "Constantinople", "Athens", "Carthage", 'B');
        }


        public void AddQuiz(string quizName, int marks, string userName)
        {
            int quizID = quizzes.FindMaxID() + 1;

            Quiz newQuiz = new Quiz
            {
                QuizID = quizID,
                QuizName = quizName,
                Marks = marks,
                Username = userName
            };
            quizzes.Insert(quizID, newQuiz);
        }

        public List<Question> GetQuestionsByQuizID(int quizID)
        {
  
            return quizzes.GetQuestionsByQuizID(quizID);
        }

        public void AddQuizStart(int quizID, string quizName, int marks, string userName)
        {
            Quiz newQuiz = new Quiz
            {
                QuizID = quizID,
                QuizName = quizName,
                Marks = marks,
                Username = userName
            };
            quizzes.Insert(quizID, newQuiz);
        }


        public void DeleteQuiz(int quizID)
        {
            quizzes.Remove(quizID);
        }



        //this one ok
        public void AddQuestion(int quizID, string questionText, string answerA, string answerB, string answerC, string answerD, char correctAnswer)
        {
            if (quizzes.Search(quizID) == null) return;

            Question newQuestion = new Question
            {
                QuestionID = quizzes.Search(quizID).Questions.Count + 1,
                QuestionText = questionText,
                AnswerA = answerA,
                AnswerB = answerB,
                AnswerC = answerC,
                AnswerD = answerD,
                CorrectAnswer = correctAnswer
            };

            var quiz = quizzes.Search(quizID);
            quiz.Questions.Add(newQuestion);
        }

    }

    public class BinarySearchTree
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

            while (current != null && current.Value.Marks < newNode.Value.Marks)
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

    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public int Marks { get; set; }
        public string Username { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        // Add a question to the quiz, this has implemented  
        public void AddQuestion(Question question)
        {
            if (question == null) throw new ArgumentNullException(nameof(question));
            Questions.Add(question);
        }

        // This Remove a question by index; but in the frontend this function has not implement yet
        public void RemoveQuestion(int index)
        {
            if (index < 0 || index >= Questions.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            Questions.RemoveAt(index);
        }
    }


    // This is the class for Questions and its objects store inside the Quiz class object as a list
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public char CorrectAnswer { get; set; }
    }
}