using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Webglobic.Models;
using Webglobic.Services;
using System.Collections.Generic;
using System.Linq;

namespace Webglobic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryControllers : ControllerBase
    {
        private readonly StorageBroker _context;

        public CountryControllers(StorageBroker context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<Country>>> GetAllCountry([FromServices] StorageBroker context)
        {
            return await context.Country.ToListAsync();
        }


        [Authorize]
        [HttpGet("odata/Country({id})")]
        [EnableQuery]
        public async Task<ActionResult<Country>> GetCountry(Guid id)
        {
            var Country = await _context.Country.FindAsync(id);

            if (Country == null)
            {
                return NotFound();
            }

            return Country;
        }

        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(Country country)
        {
            _context.Country.Add(country);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCountry), new { id = country.Id }, country);
        }

        [HttpPut]
        public async Task<ActionResult<Country>> PutCountry(Guid id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }
            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryAvailable(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }
        private bool CountryAvailable(Guid id)
        {
            return (_context.Country?.Any(x => x.Id == id)).GetValueOrDefault();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            if (_context.Country == null)
            {
                return NotFound();
            }
            var country = await _context.Country.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            _context.Country.Remove(country);

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
