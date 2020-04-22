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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new ReferencepointConfiguration());
            modelBuilder.ApplyConfiguration(new HeatmapConfiguration());
        }
    }
}
