using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuitarApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/GuitarApi")]
    [ApiController]
    public class GuitarController : ControllerBase
    {
        private readonly GuitarContext _context;

        public GuitarController(GuitarContext context)
        {
            _context = context;
        }

        // GET: api/GuitarItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GuitarItemDTO>>> GetGuitarItems()
        {
            return await _context.GuitarItems
                .Select(x => GuitarToDTO(x))
                .ToListAsync();
        }

        // GET: api/GuitarItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GuitarItemDTO>> GetGuitarItem(long id)
        {
            var todoItem = await _context.GuitarItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return GuitarToDTO(todoItem);
        }
        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGuitarItem(long id, GuitarItemDTO guitarItemDTO)
        {
            if (id != guitarItemDTO.Id)
            {
                return BadRequest();
            }

            var guitarItem = await _context.GuitarItems.FindAsync(id);
            if (guitarItem == null)
            {
                return NotFound();
            }

            guitarItem.Brand = guitarItemDTO.Brand;
            guitarItem.Collected = guitarItemDTO.Collected;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!GuitarItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }
        // POST: api/GuitarItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GuitarItemDTO>> CreateGuitarItem(GuitarItemDTO guitarItemDTO)
        {
            var guitarItem = new GuitarItem
            {
                Collected = guitarItemDTO.Collected,
                Brand = guitarItemDTO.Brand
            };

            _context.GuitarItems.Add(guitarItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetGuitarItem),
                new { id = guitarItem.Id },
                GuitarToDTO(guitarItem));
        }

        // DELETE: api/GuitarItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuitarItem(long id)
        {
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
            return _context.GuitarItems.Any(e => e.Id == id);
        }

        private static GuitarItemDTO GuitarToDTO(GuitarItem guitarItem) =>
            new GuitarItemDTO
            {
                Id = guitarItem.Id,
                Brand = guitarItem.Brand,
                Collected = guitarItem.Collected
            };
    }
}