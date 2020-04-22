using FruitFly.Repository.Configurations;
using FruitFly.Repository.Models;
using FruitFly.Test.Utilities;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using FruitFly.Repository;
using Microsoft.EntityFrameworkCore;

namespace FruitFly.Test
{
    [SetUpFixture]
    public class UnitTestSetUp
    {
        [OneTimeSetUp]
        public async Task SetUp()
        {
            using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
            {
                await db.Database.EnsureDeletedAsync();
                await db.Database.EnsureCreatedAsync();
            }
        }
    }
    public class UnitTestDataLayer
    {
        [Test]
        public void Get_Referencepoint()
        {
            using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
            {
                List<Referencepoint> referencepoints = db.Referencepoints
                    .AsNoTracking()
                    .ToList();

                Assert.AreEqual(referencepoints.Count > 0, true);
            }
        }

        [Test]
        public void Get_Heatmap()
        {
            using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
            {
                List<Heatmap> heatmaps = db.Heatmaps
                    .AsNoTracking()
                    .ToList();

                Assert.AreEqual(heatmaps.Count > 0, true);
            }
        }

        //[Test]
        //public void Get_ReferencepointId()
        //{
        //    using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
        //    {


        //    }
        //}

        //[Test]
        //public void Get_ReferencepointId()
        //{
        //    using (var db = new FruitFlyContext(SQLContext.TestDbContextOptions()))
        //    {


        //    }
        //}
    }
}