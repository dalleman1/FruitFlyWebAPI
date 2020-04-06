using FruitFly.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Repository.Interfaces
{
    public interface IHeatmapRepository : ICrudRepository<Heatmap>
    {
        Task<bool> DoesHeatmapExist(int heatmapId);

    }
}
