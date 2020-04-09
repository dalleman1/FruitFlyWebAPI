using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FruitFly.API.Authorization;
using FruitFly.Repository.Models;
using FruitFly.Service.Interfaces;
using FruitFly.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace FruitFly.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKeyAuth]
    public class HeatmapController : ControllerBase
    {
        private readonly IHeatmapService _heatmapService;

        public HeatmapController(IHeatmapService heatmapService)
        {
            _heatmapService = heatmapService;
        }

        //GET api/heatmap
        [HttpGet]
        public async Task<ActionResult<List<Heatmap>>> Get()
        {
            return await _heatmapService.GetAllAsync();
        }

        //GET api/heatmap/5
        [HttpGet("{heatmapId}")]
        public async Task<ActionResult<Heatmap>> Get(int heatmapId)
        {
            Heatmap heatmap = await _heatmapService.GetByIdAsync(heatmapId);
            if (heatmap == null)
            {
                return NotFound();
            }
            return heatmap;
        }

        //POST api/heatmap
        [HttpPost]
        public async Task<IActionResult> Post(Heatmap heatmap)
        {
            Heatmap _heatmap = await _heatmapService.AddAsync(heatmap);
            if (_heatmap == null)
            {
                return NotFound();
            }
            return CreatedAtAction(nameof(Get), _heatmap);
        }

        // PUT api/heatmap/5
        [HttpPut("{heatmapId}")]
        public async Task<IActionResult> Put(int heatmapId, Heatmap heatmap)
        {
            if (heatmapId != heatmap.HeatmapID)
            {
                return BadRequest();
            }
            await _heatmapService.UpdateAsync(heatmap);

            return NoContent();
        }

        // DELETE api/heatmap/5
        [HttpDelete("{heatmapId}")]
        public async Task<IActionResult> Delete(int heatmapId)
        {
            Heatmap heatmap = await _heatmapService.GetByIdAsync(heatmapId);
            if (heatmap == null)
            {
                return NotFound();
            }
            await _heatmapService.RemoveAsync(heatmap);
            return NoContent();
        }


        //THIS IS BAD PRACTICE / GARBAGE / NO BUENO
        //Delete api/heatmap/
        [HttpDelete]
        public async Task<ActionResult<List<Heatmap>>> Delete()
        {
            await _heatmapService.RemoveAllAsync();
            return Ok();
        }


    }
}
