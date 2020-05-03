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
        //    optionsBuilder.UseSqlServer("Server=tcp:fruitfly.database.windows.net,1433;Initial Catalog=FruitFlyDb;Persist Security Info=False;User ID=dalle;Password=Frugtflue1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to many relationship -> it is possible for a heatmap to have more referencepoints (more persons on the same point)
            //modelBuilder.Entity<Heatmap>()
            //    .HasMany(c => c.Referencepoints)
            //    .WithOne(e => e.Heatmap);
            // Static data for testing purposes
            modelBuilder.ApplyConfiguration(new ReferencepointConfiguration());
            modelBuilder.ApplyConfiguration(new HeatmapConfiguration());
        }
    }
}
