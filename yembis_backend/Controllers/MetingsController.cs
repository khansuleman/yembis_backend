﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using yembis_backend.Models;

namespace yembis_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetingsController : ControllerBase
    {
        private readonly RoadwatchContext _context;

        public MetingsController(RoadwatchContext context)
        {
            _context = context;
        }

        // GET: api/Metings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meting>>> GetMetings()
        {
            return await _context.Metings.ToListAsync();
        }

        // GET: api/Metings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meting>> GetMeting(int id)
        {
            var meting = await _context.Metings.FindAsync(id);

            if (meting == null)
            {
                return NotFound();
            }

            return meting;
        }

        // PUT: api/Metings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeting(int id, Meting meting)
        {
            if (id != meting.MetingID)
            {
                return BadRequest();
            }

            _context.Entry(meting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetingExists(id))
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

        // POST: api/Metings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Meting>> PostMeting(Meting meting)
        {
            _context.Metings.Add(meting);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeting", new { id = meting.MetingID }, meting);
        }

        // DELETE: api/Metings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeting(int id)
        {
            var meting = await _context.Metings.FindAsync(id);
            if (meting == null)
            {
                return NotFound();
            }

            _context.Metings.Remove(meting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MetingExists(int id)
        {
            return _context.Metings.Any(e => e.MetingID == id);
        }
    }
}