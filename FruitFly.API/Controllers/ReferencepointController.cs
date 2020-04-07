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
    public class ReferencepointController : ControllerBase
    {
        private readonly IReferencepointService _referencepointService;

        public ReferencepointController(IReferencepointService referencepointService)
        {
            _referencepointService = referencepointService;
        }

        //GET api/referencepoint
        [HttpGet]
        public async Task<ActionResult<List<Referencepoint>>> Get()
        {
            return await _referencepointService.GetAllAsync();
        }

        //GET api/referencepoint/5
        [HttpGet("{referencepointId}")]
        public async Task<ActionResult<Referencepoint>> Get(int referencepointId)
        {
            Referencepoint referencepoint = await _referencepointService.GetByIdAsync(referencepointId);
            if (referencepoint == null)
            {
                return NotFound();
            }
            return referencepoint;
        }

        //POST api/referencepoint
        [HttpPost]
        public async Task<IActionResult> Post(Referencepoint referencepoint)
        {
            Referencepoint _referencepoint = await _referencepointService.AddAsync(referencepoint);
            if (_referencepoint == null)
            {
                return StatusCode(400);
            }
            return StatusCode(201);
        }

        // PUT api/referencepoint/5
        [HttpPut("{referencepointId}")]
        public async Task<IActionResult> Put(int referencepointId, Referencepoint referencepoint)
        {
            if (referencepointId != referencepoint.ReferencepointId)
            {
                return BadRequest();
            }
            await _referencepointService.UpdateAsync(referencepoint);

            return NoContent();
        }

        // DELETE api/referencepoint/5
        [HttpDelete("{referencepointId}")]
        public async Task<IActionResult> Delete(int referencepointId)
        {
            Referencepoint referencepoint = await _referencepointService.GetByIdAsync(referencepointId);
            if (referencepoint == null)
            {
                return NotFound();
            }
            await _referencepointService.RemoveAsync(referencepoint);
            return NoContent();
        }
    }
}