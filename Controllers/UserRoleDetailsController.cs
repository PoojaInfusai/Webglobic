using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Webglobic.Models;
using Webglobic.Services;

namespace Webglobic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleDetailsController : Controller
    {
            private readonly StorageBroker _context;

            public UserRoleDetailsController(StorageBroker context)
            {
                _context = context;
            }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<UserRoleDetails>>> GetAllUserRoleDetails([FromServices] StorageBroker context)
        {
            return await context.UserRoleDetails.ToListAsync();
        }


        [HttpGet("odata/UserRoleDetails({id})")]
            [EnableQuery]
            public async Task<ActionResult<UserRoleDetails>> GetUserRoleDetails(Guid id)
            {
                var UserRoleDetails = await _context.UserRoleDetails.FindAsync(id);

                if (UserRoleDetails == null)
                {
                    return NotFound();
                }

                return UserRoleDetails;
            }


            [HttpPost]
            public async Task<ActionResult<UserRoleDetails>> PostUserRoleDetails(UserRoleDetails userRoleDetails)
            {
                _context.UserRoleDetails.Add(userRoleDetails);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUserRoleDetails), new { id = userRoleDetails.Id }, userRoleDetails);
            }

        [HttpPut]
        public async Task<ActionResult<UserRoleDetails>> PutUserRoleDetails(Guid id, UserRoleDetails userRoleDetails)
        {
            if (id != userRoleDetails.Id)
            {
                return BadRequest();
            }
            _context.Entry(userRoleDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserRoleDetailsAvailable(id))
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
        private bool UserRoleDetailsAvailable(Guid id)
        {
            return (_context.UserRoleDetails?.Any(x => x.Id == id)).GetValueOrDefault();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoleDetails(int id)
            {
                if (_context.UserRoleDetails == null)
                {
                    return NotFound();
                }
                var userRoleDetails = await _context.UserRoleDetails.FindAsync(id);
                if (userRoleDetails == null)
                {
                    return NotFound();
                }
                _context.UserRoleDetails.Remove(userRoleDetails);

                await _context.SaveChangesAsync();
                return Ok();
            }
        
    }
}
