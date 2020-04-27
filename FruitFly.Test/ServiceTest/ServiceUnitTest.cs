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
using FruitFly.Service.Services;

namespace FruitFly.Test.ServiceTest
{
    //This is a test suite for the repository functions - Tested with referencepoints
    //In essence referencepoint and heatmaprepository does the same
    [TestFixture]
    public class ServiceUnitTest
    {
        private readonly FruitFlyContext _fruitFlyContext;
        private readonly ReferencepointService _referencepointService;
        private readonly ReferencepointRepository _referencepointRepository;
        public ServiceUnitTest()
        {
            _fruitFlyContext = new FruitFlyContext(SQLContext.TestDbContextOptions());
            _referencepointRepository = new ReferencepointRepository(_fruitFlyContext);
            _referencepointService = new ReferencepointService(_referencepointRepository);
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
            await _referencepointService.AddAsync(new Referencepoint());
            Assert.That((await _referencepointService.GetAllAsync()).Count == 1);
        }

        [Test]
        public async Task GetAllAsync()
        {
            await _referencepointService.AddAsync(new Referencepoint());
            Assert.AreEqual((await _referencepointService.GetAllAsync()).Count > 0, true);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            Assert.That(await _referencepointService.GetByIdAsync(1) == null);
        }

        [Test]
        public async Task RemoveAsync()
        {
            await _referencepointService.AddAsync(new Referencepoint { ReferencepointId = 1 });
            await _referencepointService.RemoveAsync(1);
            Assert.AreEqual((await _referencepointService.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task RemoveRangeAsync()
        {
            await _referencepointService.AddAsync(new Referencepoint());
            await _referencepointService.AddAsync(new Referencepoint());
            List<Referencepoint> mylist = await _referencepointService.GetAllAsync();
            await _referencepointService.RemoveRangeAsync(mylist);
            Assert.AreEqual((await _referencepointService.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task UpdateAsync()
        {
            Referencepoint referencepoint = new Referencepoint { X = 2 };
            await _referencepointService.AddAsync(referencepoint);
            referencepoint.X = 4;
            await _referencepointService.UpdateAsync(referencepoint);
            var referencepointdouble = await _referencepointService.GetAllAsync();
            Assert.AreEqual(referencepointdouble.First().X, referencepoint.X);
        }
    }
}
