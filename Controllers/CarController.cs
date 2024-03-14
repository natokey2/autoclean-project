using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoclean.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Autoclean.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CarController(AppDbContext context)
        {
            _context =context;
        }

        [HttpGet]

        public async Task<IActionResult> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return Ok(cars);
        }

        [HttpGet("id")]

        public async Task<IActionResult> GetCars(int Id)
        {
            var cars = await _context.Cars.FindAsync(Id);
            
             if (cars == null)
        {
            return NotFound();
        }
            return Ok(cars);

            
        }
    }
}