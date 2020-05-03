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
    public class HeatmapConfiguration : IEntityTypeConfiguration<Heatmap>
    {
        public void Configure(EntityTypeBuilder<Heatmap> entity)
        {
            var rand = new Random();
            //250 heatmapdata for testing
            for (int i = 1; i < 250; i++)
            {
                entity.HasData(
                    new Heatmap
                    {
                        HeatmapID = i,
                        ReferencepointId = i
                    }
                    );
            }
        }
    }
}
