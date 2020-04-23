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
    public class HeatmapUnitTest
    {
        private readonly FruitFlyContext _fruitFlyContext;
        private readonly HeatmapRepository _heatmapRepository;
        public HeatmapUnitTest()
        {
            _fruitFlyContext = new FruitFlyContext(SQLContext.TestDbContextOptions());
            _heatmapRepository = new HeatmapRepository(_fruitFlyContext);
        }

        [TearDown]
        public async Task Dispose()
        {
            List<Heatmap> mylist = await _heatmapRepository.GetAllAsync();
            await _heatmapRepository.RemoveRangeAsync(mylist);
        }

        [Test]
        public async Task AddAsync()
        {
            await _heatmapRepository.AddAsync(new Heatmap());
            Assert.That(await _heatmapRepository.DoesHeatmapExist(1) == true);
        }

        [Test]
        public async Task GetAllAsync()
        {
            await _heatmapRepository.AddAsync(new Heatmap());
            Assert.AreEqual((await _heatmapRepository.GetAllAsync()).Count > 0, true);
        }

        [Test]
        public async Task GetByIdAsync()
        {
            Assert.That(await _heatmapRepository.GetByIdAsync(1) == null);
        }

        [Test]
        public async Task RemoveAsync()
        {
            await _heatmapRepository.AddAsync(new Heatmap { HeatmapID = 1 });
            await _heatmapRepository.RemoveAsync(1);
            Assert.AreEqual((await _heatmapRepository.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task RemoveRangeAsync()
        {
            await _heatmapRepository.AddAsync(new Heatmap());
            await _heatmapRepository.AddAsync(new Heatmap());
            List<Heatmap> mylist = await _heatmapRepository.GetAllAsync();
            await _heatmapRepository.RemoveRangeAsync(mylist);
            Assert.AreEqual((await _heatmapRepository.GetAllAsync()).Count == 0, true);
        }

        [Test]
        public async Task UpdateAsync()
        {
            Heatmap heatmap = new Heatmap {  ReferencepointId = 1 };
            await _heatmapRepository.AddAsync(heatmap);
            heatmap.ReferencepointId = 4;
            await _heatmapRepository.UpdateAsync(heatmap);
            var heatmapdouble = await _heatmapRepository.GetAllAsync();
            Assert.AreEqual(heatmapdouble.First().ReferencepointId, heatmap.ReferencepointId);
        }
    }
}