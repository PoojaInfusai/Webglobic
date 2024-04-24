using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Webglobic.Models;
using Webglobic.Services;

namespace Webglobic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : Controller
    {
            private readonly StorageBroker _context;

            public UserRoleController(StorageBroker context)
            {
                _context = context;
            }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<UserRoles>>> GetAllUserRoles([FromServices] StorageBroker context)
        {
            return await context.UserRoles.ToListAsync();
        }


        [HttpGet("odata/UserRoles({id})")]
            [EnableQuery]
            public async Task<ActionResult<UserRoles>> GetUserRoles(Guid id)
            {
                var UserRoles = await _context.UserRoles.FindAsync(id);

                if (UserRoles == null)
                {
                    return NotFound();
                }

                return UserRoles;
            }


            [HttpPost]
            public async Task<ActionResult<UserRoles>> PostUserRoles(UserRoles userRoles)
            {
                _context.UserRoles.Add(userRoles);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUserRoles), new { id = userRoles.Id }, userRoles);
            }

        [HttpPut]
        public async Task<ActionResult<UserRoles>> PutCountry(Guid id, UserRoles userRoles)
        {
            if (id != userRoles.Id)
            {
                return BadRequest();
            }
            _context.Entry(userRoles).State = EntityState.Modified;

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
            public async Task<IActionResult> DeleteUserRoles(int id)
            {
                if (_context.UserRoles == null)
                {
                    return NotFound();
                }
                var userRoles = await _context.UserRoles.FindAsync(id);
                if (userRoles == null)
                {
                    return NotFound();
                }
                _context.UserRoles.Remove(userRoles);

                await _context.SaveChangesAsync();
                return Ok();
            }

    }
}
