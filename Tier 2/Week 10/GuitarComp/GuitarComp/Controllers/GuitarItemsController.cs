using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuitarComp.Models;

namespace GuitarComp.Controllers
{
    [Route("api/GuitarItems")]
    [ApiController]
    public class GuitarItemsController : ControllerBase
    {
        private readonly GuitarContext _context;

        public GuitarItemsController(GuitarContext context)
        {
            _context = context;
        }

        // GET: api/GuitarItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuitarItem>>> GetGuitarItems()
        {
          if (_context.GuitarItems == null)
          {
              return NotFound();
          }
            return await _context.GuitarItems.ToListAsync();
        }

        // GET: api/GuitarItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuitarItem>> GetGuitarItem(long id)
        {
          if (_context.GuitarItems == null)
          {
              return NotFound();
          }
            var guitarItem = await _context.GuitarItems.FindAsync(id);

            if (guitarItem == null)
            {
                return NotFound();
            }

            return guitarItem;
        }

        // PUT: api/GuitarItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuitarItem(long id, GuitarItem guitarItem)
        {
            if (id != guitarItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(guitarItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuitarItemExists(id))
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

        // POST: api/GuitarItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GuitarItem>> PostGuitarItem(GuitarItem guitarItem)
        {
            _context.GuitarItems.Add(guitarItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetGuitarItem), new { id = guitarItem.Id }, guitarItem);
        }

        // DELETE: api/GuitarItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuitarItem(long id)
        {
            if (_context.GuitarItems == null)
            {
                return NotFound();
            }
            var guitarItem = await _context.GuitarItems.FindAsync(id);
            if (guitarItem == null)
            {
                return NotFound();
            }

            _context.GuitarItems.Remove(guitarItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GuitarItemExists(long id)
        {
            return (_context.GuitarItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
