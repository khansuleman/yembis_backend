using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yembis_backend.Models;

namespace yembis_backend.Controllers
{
    [ApiController]
    [Route("/api/speedlimit")]
    
    public class SpeedLimitsController : ControllerBase
    {
        private readonly RoadwatchContext _context;

        public SpeedLimitsController(RoadwatchContext context)
        {
            _context = context;
        }

        // GET: api/SpeedLimits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpeedLimit>>> GetSpeedLimits()
        {
            return await _context.SpeedLimits.ToListAsync();
        }

        // GET: api/SpeedLimits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SpeedLimit>> GetSpeedLimit(int id)
        {
            var speedLimit = await _context.SpeedLimits.FindAsync(id);

            if (speedLimit == null)
            {
                return NotFound();
            }

            return speedLimit;
        }

        // PUT: api/SpeedLimits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpeedLimit(int id, SpeedLimit speedLimit)
        {
            if (id != speedLimit.LimitID)
            {
                return BadRequest();
            }

            _context.Entry(speedLimit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeedLimitExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SpeedLimits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SpeedLimit>> PostSpeedLimit(SpeedLimit speedLimit)
        {
            _context.SpeedLimits.Add(speedLimit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSpeedLimit", new { id = speedLimit.LimitID }, speedLimit);
        }

        // DELETE: api/SpeedLimits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpeedLimit(int id)
        {
            var speedLimit = await _context.SpeedLimits.FindAsync(id);
            if (speedLimit == null)
            {
                return NotFound();
            }

            _context.SpeedLimits.Remove(speedLimit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SpeedLimitExists(int id)
        {
            return _context.SpeedLimits.Any(e => e.LimitID == id);
        }
    }
}
