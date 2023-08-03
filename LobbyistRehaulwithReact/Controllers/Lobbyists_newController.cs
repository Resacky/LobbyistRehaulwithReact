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
    public class Lobbyists_newController : ControllerBase
    {
        private readonly LobbyistDbContext _context;

        public Lobbyists_newController(LobbyistDbContext context)
        {
            _context = context;
        }

        // GET: api/Lobbyists_new
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lobbyists_new>>> GetLobbyists_new()
        {
          if (_context.Lobbyists_new == null)
          {
              return NotFound();
          }
            return await _context.Lobbyists_new.ToListAsync();
        }

        // GET: api/Lobbyists_new/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lobbyists_new>> GetLobbyists_new(int id)
        {
          if (_context.Lobbyists_new == null)
          {
              return NotFound();
          }
            var lobbyists_new = await _context.Lobbyists_new.FindAsync(id);

            if (lobbyists_new == null)
            {
                return NotFound();
            }

            return lobbyists_new;
        }

        // PUT: api/Lobbyists_new/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLobbyists_new(int id, Lobbyists_new lobbyists_new)
        {
            if (id != lobbyists_new.ID)
            {
                return BadRequest();
            }

            _context.Entry(lobbyists_new).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Lobbyists_newExists(id))
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

        // POST: api/Lobbyists_new
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lobbyists_new>> PostLobbyists_new(Lobbyists_new lobbyists_new)
        {
          if (_context.Lobbyists_new == null)
          {
              return Problem("Entity set 'LobbyistDbContext.Lobbyists_new'  is null.");
          }
            _context.Lobbyists_new.Add(lobbyists_new);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLobbyists_new", new { id = lobbyists_new.ID }, lobbyists_new);
        }

        // DELETE: api/Lobbyists_new/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLobbyists_new(int id)
        {
            if (_context.Lobbyists_new == null)
            {
                return NotFound();
            }
            var lobbyists_new = await _context.Lobbyists_new.FindAsync(id);
            if (lobbyists_new == null)
            {
                return NotFound();
            }

            _context.Lobbyists_new.Remove(lobbyists_new);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Lobbyists_newExists(int id)
        {
            return (_context.Lobbyists_new?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
