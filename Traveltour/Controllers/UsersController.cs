﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Traveltour.Data;

namespace Traveltour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly TraveltourDBContext _context;

        public UsersController(TraveltourDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> Get_by()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                
            })
            .ToArray();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> PutUser(int id, User user)
        {
            user.Id = id;
            _context.Entry(user).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            _context.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
