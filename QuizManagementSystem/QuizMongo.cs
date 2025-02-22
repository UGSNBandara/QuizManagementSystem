using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace QuizManagementSystem
{
    public class QuizMongo
    {
        private readonly IMongoCollection<Quiz> _quizes;

        public QuizMongo()
        {
            var client = new MongoClient("mongodb+srv://sulithanb119:pbPUeKR0AuqfyWWX@cluster0.hdsld.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("QuizApp");
            _quizes = database.GetCollection<Quiz>("QuizData");
        }

        public void AddQuiz(Quiz quiz)
        {
            _quizes.InsertOne(quiz);
        }

        public List<Quiz> GetAllQuizs()
        {
            var projection = Builders<Quiz>.Projection.Exclude("_id");
            return _quizes.Find(_ => true).Project<Quiz>(projection).ToList(); return _quizes.Find(_ => true).ToList();
        }

    }
}