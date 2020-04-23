using FruitFly.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitFly.Test.Utilities
{
    public class SQLContext
    {
        public static DbContextOptions<FruitFlyContext> TestDbContextOptions()
        {
            return new DbContextOptionsBuilder<FruitFlyContext>()
            .UseInMemoryDatabase("FruitFlyTestDatabase")
            .Options;
        }
    }
}
