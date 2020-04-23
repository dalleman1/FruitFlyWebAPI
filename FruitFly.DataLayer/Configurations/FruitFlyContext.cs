using FruitFly.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FruitFly.Repository.Configurations
{
    public class FruitFlyContext : DbContext
    {
        public DbSet<Referencepoint> Referencepoints { get; set; }

        public DbSet<Heatmap> Heatmaps { get; set; }

        public FruitFlyContext(DbContextOptions<FruitFlyContext> optionsBuilder) : base(optionsBuilder)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=tcp:fruitflyserver.database.windows.net,1433;Initial Catalog=FruitFly;Persist Security Info=False;User ID=dalleman;Password=Frugtflue1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new ReferencepointConfiguration());
            modelBuilder.ApplyConfiguration(new HeatmapConfiguration());
        }
    }
}
