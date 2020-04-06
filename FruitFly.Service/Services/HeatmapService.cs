using FruitFly.Repository.Interfaces;
using FruitFly.Repository.Models;
using FruitFly.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Service.Services
{
    public class HeatmapService : CrudService<Heatmap>, IHeatmapService
    {
        private readonly IHeatmapRepository _heatmapRepository;
        public HeatmapService(IHeatmapRepository heatmapRepository) : base(heatmapRepository)
        {
            _heatmapRepository = heatmapRepository;
        }
        public async Task<bool> DoesHeatmapExist(int heatmapId)
        {
            return await _heatmapRepository.DoesHeatmapExist(heatmapId);
        }
    }
}
