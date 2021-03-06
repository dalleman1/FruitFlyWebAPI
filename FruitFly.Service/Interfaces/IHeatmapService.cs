﻿using FruitFly.Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace FruitFly.Service.Interfaces
{
    public interface IHeatmapService : ICrudService<Heatmap>
    {
        Task<bool> DoesHeatmapExist(int heatmapId);
    }
}
