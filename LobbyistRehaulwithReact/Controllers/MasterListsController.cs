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
    public class MasterListsController : ControllerBase
    {
        private readonly LobbyistDbContext _context;

        public MasterListsController(LobbyistDbContext context)
        {
            _context = context;
        }

        // GET: api/MasterLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MasterList>>> GetMasterList()
        {
          if (_context.MasterList == null)
          {
              return NotFound();
          }
            return await _context.MasterList.ToListAsync();
        }

        // GET: api/MasterLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MasterList>> GetMasterList(int id)
        {
          if (_context.MasterList == null)
          {
              return NotFound();
          }
            var masterList = await _context.MasterList.FindAsync(id);

            if (masterList == null)
            {
                return NotFound();
            }

            return masterList;
        }

        // PUT: api/MasterLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMasterList(int id, MasterList masterList)
        {
            if (id != masterList.ID)
            {
                return BadRequest();
            }

            _context.Entry(masterList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasterListExists(id))
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

        // POST: api/MasterLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MasterList>> PostMasterList(MasterList masterList)
        {
          if (_context.MasterList == null)
          {
              return Problem("Entity set 'LobbyistDbContext.MasterList'  is null.");
          }
            _context.MasterList.Add(masterList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMasterList", new { id = masterList.ID }, masterList);
        }

        // DELETE: api/MasterLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMasterList(int id)
        {
            if (_context.MasterList == null)
            {
                return NotFound();
            }
            var masterList = await _context.MasterList.FindAsync(id);
            if (masterList == null)
            {
                return NotFound();
            }

            _context.MasterList.Remove(masterList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MasterListExists(int id)
        {
            return (_context.MasterList?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
