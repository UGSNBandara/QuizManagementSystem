using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizManagementSystem.Models
{
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
}
