using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LobbyistRehaulwithReact.Data;
using LobbyistRehaulwithReact.Models;

namespace LobbyistRehaulwithReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Issues2Controller : ControllerBase
    {
        private readonly LobbyistDbContext _context;

        public Issues2Controller(LobbyistDbContext context)
        {
            _context = context;
        }

        // GET: api/Issues2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Issues2>>> GetIssues2()
        {
          if (_context.Issues2 == null)
          {
              return NotFound();
          }
            return await _context.Issues2.ToListAsync();
        }

        // GET: api/Issues2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Issues2>> GetIssues2(int id)
        {
          if (_context.Issues2 == null)
          {
              return NotFound();
          }
            var issues2 = await _context.Issues2.FindAsync(id);

            if (issues2 == null)
            {
                return NotFound();
            }

            return issues2;
        }

        // PUT: api/Issues2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssues2(int id, Issues2 issues2)
        {
            if (id != issues2.ID)
            {
                return BadRequest();
            }

            _context.Entry(issues2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Issues2Exists(id))
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

        // POST: api/Issues2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Issues2>> PostIssues2(Issues2 issues2)
        {
          if (_context.Issues2 == null)
          {
              return Problem("Entity set 'LobbyistDbContext.Issues2'  is null.");
          }
            _context.Issues2.Add(issues2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIssues2", new { id = issues2.ID }, issues2);
        }

        // DELETE: api/Issues2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssues2(int id)
        {
            if (_context.Issues2 == null)
            {
                return NotFound();
            }
            var issues2 = await _context.Issues2.FindAsync(id);
            if (issues2 == null)
            {
                return NotFound();
            }

            _context.Issues2.Remove(issues2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Issues2Exists(int id)
        {
            return (_context.Issues2?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
