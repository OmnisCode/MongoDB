using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBRepository;

namespace ConnectMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalcollection = new Repository("test").Total("restaurants").Result;            
        }
    }
}
