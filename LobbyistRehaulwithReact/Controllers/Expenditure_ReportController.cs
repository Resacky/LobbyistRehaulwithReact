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
    public class Expenditure_ReportController : ControllerBase
    {
        private readonly LobbyistDbContext _context;

        public Expenditure_ReportController(LobbyistDbContext context)
        {
            _context = context;
        }

        // GET: api/Expenditure_Report
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expenditure_Report>>> GetExpenditure_Report()
        {
          if (_context.Expenditure_Report == null)
          {
              return NotFound();
          }
            return await _context.Expenditure_Report.ToListAsync();
        }

        // GET: api/Expenditure_Report/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expenditure_Report>> GetExpenditure_Report(int id)
        {
          if (_context.Expenditure_Report == null)
          {
              return NotFound();
          }
            var expenditure_Report = await _context.Expenditure_Report.FindAsync(id);

            if (expenditure_Report == null)
            {
                return NotFound();
            }

            return expenditure_Report;
        }

        // PUT: api/Expenditure_Report/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenditure_Report(int id, Expenditure_Report expenditure_Report)
        {
            if (id != expenditure_Report.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenditure_Report).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Expenditure_ReportExists(id))
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

        // POST: api/Expenditure_Report
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Expenditure_Report>> PostExpenditure_Report(Expenditure_Report expenditure_Report)
        {
          if (_context.Expenditure_Report == null)
          {
              return Problem("Entity set 'LobbyistDbContext.Expenditure_Report'  is null.");
          }
            _context.Expenditure_Report.Add(expenditure_Report);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenditure_Report", new { id = expenditure_Report.Id }, expenditure_Report);
        }

        // DELETE: api/Expenditure_Report/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenditure_Report(int id)
        {
            if (_context.Expenditure_Report == null)
            {
                return NotFound();
            }
            var expenditure_Report = await _context.Expenditure_Report.FindAsync(id);
            if (expenditure_Report == null)
            {
                return NotFound();
            }

            _context.Expenditure_Report.Remove(expenditure_Report);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Expenditure_ReportExists(int id)
        {
            return (_context.Expenditure_Report?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
