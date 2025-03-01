using MongoDB.Bson.Serialization.Attributes;
using QuizManagementSystem.Data_Structures;
using QuizManagementSystem.MongoFiles;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace QuizManagementSystem
{
    public class QuizManager
    {
        public QuizBinaryPlusLinkedList quizzes = new QuizBinaryPlusLinkedList();
        private QuizMongo quizMongo;
        private QuestionMongo questionMongo;

        public QuizManager()
        {
            quizMongo = new QuizMongo();
            questionMongo = new QuestionMongo();

            List<Quiz> quizes = new List<Quiz>();
            quizes = quizMongo.GetAllQuizs();

            foreach (Quiz quiz in quizes)
            {
                quizzes.Insert(quiz.QuizID, quiz);
            }

            List<Question> questions = new List<Question>();
            questions = questionMongo.GetAllQuestion();

            foreach (Question question in questions)
            {
                var quiz = quizzes.Search(question.QuizId);
                quiz.Questions.Add(question);
            }

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
            quizMongo.AddQuiz(newQuiz);
        }

        public List<Question> GetQuestionsByQuizID(int quizID)
        {
  
            return quizzes.GetQuestionsByQuizID(quizID);
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
                QuizId = quizID,
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
            questionMongo.AddQuestion(newQuestion);

        }

    }


    public class Quiz
    {
        public int QuizID { get; set; }
        public string QuizName { get; set; }
        public int Marks { get; set; }
        public string Username { get; set; }

        [BsonIgnore]
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
        public int QuizId { get; set; }
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public char CorrectAnswer { get; set; }
    }
}