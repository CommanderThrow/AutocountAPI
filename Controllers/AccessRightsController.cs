using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutocountAPI.Data;
using AutocountAPI.Models;

namespace AutocountAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessRightsController : ControllerBase
    {
        private readonly AedAccountsoftContext Context;

        public AccessRightsController(AedAccountsoftContext context)
        {
            Context = context;
        }

        // GET: api/AccessRights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccessRight>>> GetAccessRights([FromQuery] int pageSize)
        {
            return await Context.AccessRights.OrderBy(x => x.AutoKey).Take(pageSize).ToListAsync();
        }

        // GET: api/AccessRights/5
        [HttpGet("{autokey}")]
        public async Task<ActionResult<AccessRight>> GetAccessRight(long autokey)
        {
            var accessRight = await Context.AccessRights.FindAsync(autokey);

            if (accessRight == null)
            {
                return NotFound();
            }

            return accessRight;
        }

        // PUT: api/AccessRights/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{autokey}")]
        public async Task<IActionResult> PutAccessRight(long autokey, AccessRight accessRight)
        {
            if (autokey != accessRight.AutoKey)
            {
                return BadRequest();
            }

            Context.Entry(accessRight).State = EntityState.Modified;
            await Context.Database.BeginTransactionAsync();

            try
            {
                AccessRight? AccessRightDB = Context.AccessRights.FirstOrDefault(x => x.AutoKey == autokey);
                if (AccessRightDB == null)
                    return BadRequest();

                AccessRightDB.CmdId = accessRight.CmdId;
                AccessRightDB.UserId = accessRight.UserId;
                await Context.SaveChangesAsync();
                await Context.Database.CommitTransactionAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessRightExists(autokey))
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

        // POST: api/AccessRights
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccessRight>> PostAccessRight(AccessRight accessRight)
        {
            try
            {
                Context.AccessRights.Add(accessRight);
                await Context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetAccessRight), new { autokey = accessRight.AutoKey }, accessRight);
            }
            catch (DbUpdateException)
            {
                return BadRequest();
            }
        }

        // DELETE: api/AccessRights/5
        [HttpDelete("{autokey}")]
        public async Task<IActionResult> DeleteAccessRight(long autokey)
        {
            var accessRight = await Context.AccessRights.FindAsync(autokey);
            if (accessRight == null)
            {
                return NotFound();
            }

            Context.AccessRights.Remove(accessRight);
            await Context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccessRightExists(long autokey)
        {
            return Context.AccessRights.Any(e => e.AutoKey == autokey);
        }
    }
}
