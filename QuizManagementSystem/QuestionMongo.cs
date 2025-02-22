using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace QuizManagementSystem
{
    public class QuestionMongo
    {
        private readonly IMongoCollection<Question> _questions;

        public QuestionMongo()
        {
            var client = new MongoClient("mongodb+srv://sulithanb119:pbPUeKR0AuqfyWWX@cluster0.hdsld.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("QuizApp");
            _questions = database.GetCollection<Question>("QuestionData");
        }

        public void AddQuestion(Question question)
        {
            _questions.InsertOne(question);
        }

        public List<Question> GetAllQuestion()
        {
            var projection = Builders<Question>.Projection.Exclude("_id");
            return _questions.Find(_ => true).Project<Question>(projection).ToList(); return _questions.Find(_ => true).ToList();
        }

    }
}