using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MongoDBTest
{
    [TestClass]
    public class OperationsMongoTest
    {
        [TestMethod]
        public void TotalRestaurants()
        {
            var total = new MongoDBRepository.Repository("test").Total("restaurants").Result;
            total.Should().Be(25359);
        }

        [TestMethod]
        public void ListEqualRestaurants()
        {
            var result = new MongoDBRepository.Repository("test").List("borough", "Manhattan").Result;
            result.Count.Should().Be(10259);
        }
        [TestMethod]
        public void ListMenorQueRestaurants()
        {
            var result = new MongoDBRepository.Repository("test").ListMenorQue("grades.score", 10).Result;
            result.Count.Should().Be(19065);
        }
    }
}
