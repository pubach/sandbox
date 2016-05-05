using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
namespace pu.dataBase.mongoDb
{
    public class TestClass
    {
        public TestClass()
        {
            /*
             To directly connect to a single MongoDB server
             (this will not auto-discover the primary even if it's a member of a replica set)*/
            //var client = new MongoClient();

            // or use a connection string
            var client = new MongoClient("mongodb://localhost:27017");

            // or, to connect to a replica set, with auto-discovery of the primary, supply a seed list of members
            //var client = new MongoClient("mongodb://localhost:27017,localhost:27018,localhost:27019");



            var database = client.GetDatabase("foo");

            var collection = database.GetCollection<BsonDocument>("bar");

            var document = new BsonDocument
{
    { "name", "MongoDB" },
    { "type", "Database" },
    { "count", 1 },
    { "info", new BsonDocument
        {
            { "x", 203 },
            { "y", 102 }
        }}
};

            collection.InsertOne(document);

            collection.InsertOneAsync(document);

            // generate 100 documents with a counter ranging from 0 - 99
            var documents = Enumerable.Range(0, 100).Select(i => new BsonDocument("counter", i));

            collection.InsertMany(documents);

            collection.InsertManyAsync(documents);

            var count = collection.Count(new BsonDocument());


            client.DropDatabase("foo");

            Console.WriteLine(count);
        }
    }
}
