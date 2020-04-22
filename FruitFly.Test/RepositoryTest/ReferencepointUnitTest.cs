using FruitFly.Repository.Configurations;
using FruitFly.Repository.Models;
using FruitFly.Test.Utilities;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using FruitFly.Repository;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework.Constraints;
using Microsoft.Data.SqlClient;
using FruitFly.Repository.Repositories;
using FruitFly.Test.RepositoryTest;

namespace FruitFly.Test.RepositoryTest
{
    [TestFixture]
    public class ReferencepointUnitTest
    {
        private readonly FruitFlyContext _fruitFlyContext;
        private readonly ReferencepointRepository _referencepointRepository;
        public ReferencepointUnitTest()
        {
            _fruitFlyContext = new FruitFlyContext(SQLContext.TestDbContextOptions());
            _referencepointRepository = new ReferencepointRepository(_fruitFlyContext);
        }

        [TearDown]
        public async Task Dispose()
        {
            List<Referencepoint> mylist = await _referencepointRepository.GetAllAsync();
            await _referencepointRepository.RemoveRangeAsync(mylist);
        }

        [Test]
        public async Task GetAllAsyncTest()
        {
            await _referencepointRepository.AddAsync(new Referencepoint());
            Assert.AreEqual((await _referencepointRepository.GetAllAsync()).Count > 0, true);
        }

        [Test]
        public async Task GetByIdAsyncTest()
        {
            Assert.That(await _referencepointRepository.GetByIdAsync(1) == null);
        }

    }
}