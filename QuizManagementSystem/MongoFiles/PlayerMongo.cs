using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace QuizManagementSystem.MongoFiles
{
    public class PlayerMongo
    {
        private readonly IMongoCollection<Player> _players;

        public PlayerMongo()
        {
            var client = new MongoClient("mongodb+srv://sulithanb119:pbPUeKR0AuqfyWWX@cluster0.hdsld.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("QuizApp");
            _players = database.GetCollection<Player>("PlayerData");
        }

        public void AddPlayer(Player player)
        {
            _players.InsertOne(player);
        }

        public List<Player> GetAllPlayers()
        {
            var projection = Builders<Player>.Projection.Exclude("_id");
            return _players.Find(_ => true).Project<Player>(projection).ToList(); return _players.Find(_ => true).ToList();
        }

        public void UpdateScore(string username, double score)
        {
            var filter = Builders<Player>.Filter.Eq(p => p.Username, username);
            var update = Builders<Player>.Update.Set(p => p.Score, score);
            _players.UpdateOne(filter, update);
        }

    }
}
