using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConnectMongo
{
    class Program
    {
        static void Main(string[] args)
        {
             IMongoClient _client;
             IMongoDatabase _database;

            _client = new MongoClient();
            _database = _client.GetDatabase("test");
        }
    }
}
