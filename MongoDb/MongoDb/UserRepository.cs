using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using MongoDB.Bson;
=======
>>>>>>> 29b6cce5dcb1e225210a7473a972a40bb9716f9f
using MongoDB.Driver;

namespace pu.dataBase.mongoDb
{
    public class UserRepository
    {
        private readonly IMongoClient _mongoClient;
        
        private const string DatabaseName = "PUbach";
        private const string CollectionName = "Users";

        public UserRepository(IMongoClient mongoClient)
        {
            _mongoClient = mongoClient;
        }

        public void Create(User user)
        {
            var db =_mongoClient.GetDatabase(DatabaseName);
            var users = db.GetCollection<User>(CollectionName);
            users.InsertOne(user);
        }
<<<<<<< HEAD

        public User GetById(int userId)
        {
            var db = _mongoClient.GetDatabase(DatabaseName);
            var userCollection = db.GetCollection<User>(CollectionName);

            var filter = Builders<User>.Filter.Eq("userId", "1");

            var result =  userCollection.Find(filter).ToListAsync();

            return result.Result.ToList().FirstOrDefault();
        }
=======
>>>>>>> 29b6cce5dcb1e225210a7473a972a40bb9716f9f
    }
}
