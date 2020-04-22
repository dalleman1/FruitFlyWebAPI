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
            // Create a new service provider to create a new SQL database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .BuildServiceProvider();

            // Create a new options instance using an SQL database and 
            // IServiceProvider that the context should resolve all of its services from.
            var builder = new DbContextOptionsBuilder<FruitFlyContext>()
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Integrated Security = True")
            .UseInternalServiceProvider(serviceProvider);

            return builder.Options;
        }
    }
}
