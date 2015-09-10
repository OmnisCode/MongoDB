using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MongoDBTest
{
    [TestClass]
    public class OperationsMongoTest
    {
        [TestMethod]
        public void TotalMongoDB()
        {
            var total = new MongoDBRepository.Repository("test").Total("restaurants").Result;
            total.Should().Be(25359);
        }
    }
}
