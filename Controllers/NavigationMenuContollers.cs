using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using Webglobic.Models;
using Webglobic.Services;

namespace Webglobic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationMenuContollers : ControllerBase
    {
       
            private readonly StorageBroker _context;

            public NavigationMenuContollers(StorageBroker context)
            {
                _context = context;
            }

        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<NavigationMenu>>> GetNavigationMenu([FromServices] StorageBroker context)
        {
            return await context.NavigationMenu.ToListAsync();
        }

        [HttpGet("odata/NavigationMenu({id})")]
            [EnableQuery]
            public async Task<ActionResult<NavigationMenu>> GetNavigationMenu(Guid id)
            {
                var NavigationMenu = await _context.NavigationMenu.FindAsync(id);

                if (NavigationMenu == null)
                {
                    return NotFound();
                }

                return NavigationMenu;
            }


            [HttpPost]
            public async Task<ActionResult<NavigationMenu>> PostNavigationMenu(NavigationMenu navigationMenu)
            {
                _context.NavigationMenu.Add(navigationMenu);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetNavigationMenu), new { id = navigationMenu.Id }, navigationMenu);
            }
        [HttpPut]
        public async Task<ActionResult<NavigationMenu>> PutNavigationMenu(Guid id, NavigationMenu navigationMenu)
        {
            if (id != navigationMenu.Id)
            {
                return BadRequest();
            }
            _context.Entry(navigationMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NavigationMenuAvailable(id))
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
        private bool NavigationMenuAvailable(Guid id)
        {
            return (_context.NavigationMenu?.Any(x => x.Id == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteNavigationMenu(int id)
            {
                if (_context.NavigationMenu == null)
                {
                    return NotFound();
                }
                var navigationMenu = await _context.NavigationMenu.FindAsync(id);
                if (navigationMenu == null)
                {
                    return NotFound();
                }
                _context.NavigationMenu.Remove(navigationMenu);

                await _context.SaveChangesAsync();
                return Ok();
            }
        }
    
}
