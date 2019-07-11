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
    [Route("api/[controller]")]
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


    }
}