using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitFly.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FruitFly.Repository.Configurations
{
    public class ReferencepointConfiguration : IEntityTypeConfiguration<Referencepoint>
    {
        public void Configure(EntityTypeBuilder<Referencepoint> entity)
        {
            var rand = new Random();
            //250 referencepoints for testing
            for (int i = 1; i < 250; i++)
            {
                entity.HasData(
                    new Referencepoint
                    {
                        ReferencepointId = i,
                        Category = rand.Next(1, 10),
                        RSSI1 = rand.Next(1, 100),
                        RSSI2 = rand.Next(1, 100),
                        RSSI3 = rand.Next(1, 100),
                        X = rand.Next(1, 100),
                        Y = rand.Next(1, 100),
                        //HeatmapId = i,
                    }
                    );
            }
        }
    }
}
