using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityApiBackEnd.DataAccess;
using UniversityApiBackEnd.Models.DataModels;

namespace UniversityApiBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapitulosController : ControllerBase
    {
        private readonly UniversityDBContext _context;

        public CapitulosController(UniversityDBContext context)
        {
            _context = context;
        }

        // GET: api/Capitulos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Capitulos>>> GetCapitulos()
        {
            return await _context.Capitulos.ToListAsync();
        }

        // GET: api/Capitulos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Capitulos>> GetCapitulos(int id)
        {
            var capitulos = await _context.Capitulos.FindAsync(id);

            if (capitulos == null)
            {
                return NotFound();
            }

            return capitulos;
        }

        // PUT: api/Capitulos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapitulos(int id, Capitulos capitulos)
        {
            if (id != capitulos.Id)
            {
                return BadRequest();
            }

            _context.Entry(capitulos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CapitulosExists(id))
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

        // POST: api/Capitulos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Capitulos>> PostCapitulos(Capitulos capitulos)
        {
            _context.Capitulos.Add(capitulos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCapitulos", new { id = capitulos.Id }, capitulos);
        }

        // DELETE: api/Capitulos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapitulos(int id)
        {
            var capitulos = await _context.Capitulos.FindAsync(id);
            if (capitulos == null)
            {
                return NotFound();
            }

            _context.Capitulos.Remove(capitulos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CapitulosExists(int id)
        {
            return _context.Capitulos.Any(e => e.Id == id);
        }
    }
}
