using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProj.Models;

namespace WebApiProj.Controllers
{
    [Route("api/dentist")]
    [ApiController]
    public class DentistController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DentistController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Dentist
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dentist>>> GetDentists()
        {
            return await _context.Dentists.ToListAsync();
        }

        // GET: api/Dentist/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dentist>> GetDentist(int id)
        {
            var dentist = await _context.Dentists.Where(d => d.DentistId == id)
                .Include(d => d.Patients).FirstOrDefaultAsync();

            if (dentist == null)
            {
                return NotFound();
            }

            return dentist;
        }

        // POST: api/Dentist
        [HttpPost]
        public async Task<ActionResult<Dentist>> PostDentist(Dentist dentist)
        {
            _context.Dentists.Add(dentist);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDentist), new { id = dentist.DentistId }, dentist);
        }

        // PUT: api/Dentist/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDentist(int id, Dentist dentist)
        {
            if (id != dentist.DentistId)
            {
                return BadRequest();
            }

            _context.Entry(dentist).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Dentist/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDentist(int id)
        {
            var dentist = await _context.Dentists.FindAsync(id);

            if (dentist == null)
            {
                return NotFound();
            }

            _context.Dentists.Remove(dentist);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}