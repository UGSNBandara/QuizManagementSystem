using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace QuizManagementSystem.MongoFiles
{
    public class MasterMongo
    {
        private readonly IMongoCollection<Master> _masters;

        public MasterMongo()
        {
            var client = new MongoClient("mongodb+srv://sulithanb119:pbPUeKR0AuqfyWWX@cluster0.hdsld.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("QuizApp");
            _masters = database.GetCollection<Master>("MasterData");
        }

        public void AddMaster(Master master)
        {
            _masters.InsertOne(master);
        }

        public List<Master> GetAllPlayers()
        {
            var projection = Builders<Master>.Projection.Exclude("_id");
            return _masters.Find(_ => true).Project<Master>(projection).ToList(); return _masters.Find(_ => true).ToList();
        }



    }
}