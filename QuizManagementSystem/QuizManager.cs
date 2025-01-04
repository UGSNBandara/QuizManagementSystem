using System;
using System.Collections.Generic;

namespace QuizManagementSystem
{
    public class QuizManager
    {
        private BinarySearchTree<int, Quiz> quizzes = new BinarySearchTree<int, Quiz>();
        private Dictionary<int, List<Question>> questionsByQuizID = new Dictionary<int, List<Question>>();

        public QuizManager()
        {
            AddQuizStart(1,"Math Quiz", 100, "Dulitha");
            AddQuizStart(2,"Science Quiz", 80, "Sulitha");

            AddQuestion(1, "What is 2+2?", "3", "4", "5", "6", 'B');
            AddQuestion(1, "What is 10/2?", "2", "5", "10", "20", 'B');
            AddQuestion(2, "What is H2O?", "Water", "Hydrogen", "Oxygen", "Carbon Dioxide", 'A');
        }

        public Dictionary<int, Quiz> GetQuiz()
        {
            return quizzes.ToDictionary();
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
            if (questionsByQuizID.ContainsKey(quizID))
            {
                questionsByQuizID.Remove(quizID);
            }
        }

        public Dictionary<int, List<Question>> LoadQuestionsGroupedByQuizID()
        {
            return questionsByQuizID;
        }

        public void AddQuestion(int quizID, string questionText, string answerA, string answerB, string answerC, string answerD, char correctAnswer)
        {
            if (!questionsByQuizID.ContainsKey(quizID))
            {
                questionsByQuizID[quizID] = new List<Question>();
            }

            Question newQuestion = new Question
            {
                QuestionID = questionsByQuizID[quizID].Count + 1,
                QuizID = quizID,
                QuestionText = questionText,
                AnswerA = answerA,
                AnswerB = answerB,
                AnswerC = answerC,
                AnswerD = answerD,
                CorrectAnswer = correctAnswer
            };

            questionsByQuizID[quizID].Add(newQuestion);
        }

        public void DeleteQuestion(int questionID)
        {
            foreach (var quiz in questionsByQuizID.Values)
            {
                quiz.RemoveAll(q => q.QuestionID == questionID);
            }
        }
    }

    public class BinarySearchTree<TKey, TValue> where TKey : IComparable<TKey>
    {
        private class Node
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private Node root;

        public void Insert(TKey key, TValue value)
        {
            root = Insert(root, key, value);
        }

        public TKey FindMaxID()
        {
            Node max = FindMax(root);
            return max == null ? (TKey)(object)0 : max.Key;
        }

        private Node Insert(Node node, TKey key, TValue value)
        {
            if (node == null) return new Node(key, value);

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
                node.Value = value; // Update value if key exists
            }

            return node;
        }

        public void Remove(TKey key)
        {
            root = Remove(root, key);
        }

        private Node Remove(Node node, TKey key)
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
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                Node temp = FindMin(node.Right);
                node.Key = temp.Key;
                node.Value = temp.Value;
                node.Right = Remove(node.Right, temp.Key);
            }

            return node;
        }

        private Node FindMin(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }

        private Node FindMax(Node node)
        {
            while (node.Right != null) node = node.Right;
            return node;
        }

        public TValue Search(TKey key)
        {
            Node node = Search(root, key);
            return node.Value;
        }

        private Node Search(Node node, TKey key)
        {
            if (node == null || key.CompareTo(node.Key) == 0) return node;

            if (key.CompareTo(node.Key) < 0) return Search(node.Left, key);

            return Search(node.Right, key);
        }

        public Dictionary<TKey, TValue> ToDictionary()
        {
            var dictionary = new Dictionary<TKey, TValue>();
            InOrderTraversal(root, dictionary);
            return dictionary;
        }

        private void InOrderTraversal(Node node, Dictionary<TKey, TValue> dictionary)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, dictionary);
            dictionary[node.Key] = node.Value;
            InOrderTraversal(node.Right, dictionary);
        }
    }

    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public int Marks { get; set; }
        public string Username { get; set; }
    }

    public class Question
    {
        public int QuestionID { get; set; }
        public int QuizID { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public char CorrectAnswer { get; set; }
    }
}
