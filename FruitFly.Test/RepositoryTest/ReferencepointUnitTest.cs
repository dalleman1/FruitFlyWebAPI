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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        public async Task AddAsync()
        {
            await _referencepointRepository.AddAsync(new Referencepoint());
            Assert.That((await _referencepointRepository.GetAllAsync()).Count == 1);
        }

        [Test]
        public async Task GetAllAsync()
        {
            await _referencepointRepository.AddAsync(new Referencepoint());
            Assert.AreEqual((await _referencepointRepository.GetAllAsync()).Count > 0, true);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            Assert.That(await _referencepointRepository.GetByIdAsync(1) == null);
        }

        [Test]
        public async Task RemoveAsync()
        {
            await _referencepointRepository.AddAsync(new Referencepoint { ReferencepointId = 1 });
            await _referencepointRepository.RemoveAsync(1);
            Assert.AreEqual((await _referencepointRepository.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task RemoveRangeAsync()
        {
            await _referencepointRepository.AddAsync(new Referencepoint());
            await _referencepointRepository.AddAsync(new Referencepoint());
            List<Referencepoint> mylist = await _referencepointRepository.GetAllAsync();
            await _referencepointRepository.RemoveRangeAsync(mylist);
            Assert.AreEqual((await _referencepointRepository.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task UpdateAsync()
        {
            Referencepoint referencepoint = new Referencepoint { X = 2};
            await _referencepointRepository.AddAsync(referencepoint);
            referencepoint.X = 4;
            await _referencepointRepository.UpdateAsync(referencepoint);
            var referencepointdouble = await _referencepointRepository.GetAllAsync();
            Assert.AreEqual(referencepointdouble.First().X, referencepoint.X);
        }
    }
}