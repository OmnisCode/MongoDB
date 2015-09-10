using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBRepository
{
    public class Repository
    {
        IMongoClient _client;
        IMongoDatabase _database;
        public Repository(string database)
        {
            _client = new MongoClient();
            _database = _client.GetDatabase(database);
        }

        public async Task<int> Total(string collectionname)
        {
            var collection = _database.GetCollection<BsonDocument>(collectionname);
            var filter = new BsonDocument();
            var count = 0;
            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        // process document
                        count++;
                    }
                }
            }

            return count;
        }

        public async Task<List<BsonDocument>> List(string field, string value)
        {
            var collection = _database.GetCollection<BsonDocument>("restaurants");
            var filter = Builders<BsonDocument>.Filter.Eq(field, value);
            var result = await collection.Find(filter).ToListAsync();
            return result;
        }
    }
}
