using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace QuizManagementSystem
{
    public class QuizManager
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\sulit\\Documents\\loginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Dictionary<int, Quiz> GetQuiz()
        {
            //here i just declared a disctionary to store the quiz index as the key and valur as the quiz class object
            Dictionary<int, Quiz> quizzes = new Dictionary<int, Quiz>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT QuizID, QuizName, Marks, UserName FROM Quizzes";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    quizzes.Add(
                        reader.GetInt32(0), // here it store the quiz index as the key
                        new Quiz
                        {
                            QuizID = reader.GetInt32(0),
                            QuizName = reader.GetString(1),
                            Marks = reader.GetInt32(2),
                            Username = reader.GetString(3)
                        }
                    );
                }
            }

            return quizzes;
        }


        //this method to add the quizes to the database
        public void AddQuiz(string quizName, int marks, string userName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Quizzes (QuizName, Marks, UserName) VALUES (@QuizName, @Marks, @UserName)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@QuizName", quizName);
                cmd.Parameters.AddWithValue("@Marks", marks);
                cmd.Parameters.AddWithValue("@UserName", userName);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //this method to delete the quiz from the database
        public void DeleteQuiz(int quizID)
        {
            DeleteWholeQuiz(quizID);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Quizzes WHERE QuizID = @QuizID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@QuizID", quizID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //from here methods are for the questions

        public Dictionary<int, List<Question>> LoadQuestionsGroupedByQuizID()
        {
            Dictionary<int, List<Question>> questionsByQuizID = new Dictionary<int, List<Question>>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT QuizID, QuestionID, QuestionText, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswer FROM Questions";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int quizID = reader.GetInt32(0); 

                    Question question = new Question
                    {
                        QuestionID = reader.GetInt32(1),
                        QuestionText = reader.GetString(2),
                        AnswerA = reader.GetString(3),
                        AnswerB = reader.GetString(4),
                        AnswerC = reader.GetString(5),
                        AnswerD = reader.GetString(6),
                        CorrectAnswer = reader.GetString(7)[0], // Assumes CorrectAnswer is a CHAR(1)
                    };

                    if (!questionsByQuizID.ContainsKey(quizID))
                    {
                        questionsByQuizID[quizID] = new List<Question>();
                    }
                    questionsByQuizID[quizID].Add(question);
                }
            }

            return questionsByQuizID;
        }

        public void AddQuestion(int quizID, string questionText, string answerA, string answerB, string answerC, string answerD, char correctAnswer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Questions (QuizID, QuestionText, AnswerA, AnswerB, AnswerC, AnswerD, CorrectAnswer) " +
                               "VALUES (@QuizID, @QuestionText, @AnswerA, @AnswerB, @AnswerC, @AnswerD, @CorrectAnswer)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@QuizID", quizID);
                cmd.Parameters.AddWithValue("@QuestionText", questionText);
                cmd.Parameters.AddWithValue("@AnswerA", answerA);
                cmd.Parameters.AddWithValue("@AnswerB", answerB);
                cmd.Parameters.AddWithValue("@AnswerC", answerC);
                cmd.Parameters.AddWithValue("@AnswerD", answerD);
                cmd.Parameters.AddWithValue("@CorrectAnswer", correctAnswer);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteQuestion(int questionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Questions WHERE QuestionID = @QuestionID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@QuestionID", questionID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteWholeQuiz(int quizID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Questions WHERE QuizID = @QuizID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@QuizID", quizID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }


    //here this is the class for the quiz, which we use as the object to store the quiz details. 
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
        public int QuizID { get; set; } //gonna use this for identify the Quiz
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public char CorrectAnswer { get; set; }
    }

}
