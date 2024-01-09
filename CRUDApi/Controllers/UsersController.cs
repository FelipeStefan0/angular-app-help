using System.Collections.Generic;
using System.Threading.Tasks;
using CRUDApi.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDApi.Controllers
{
    //[Authorize(Roles = "Administradores")]
    [ApiController]
    [Route ("api/[controller]")]
    
    public class UserController : ControllerBase
    {
        private readonly Context _context;

        // Injeção de dependência para manipulação
        public UserController(Context context) 
        {
            _context = context;
        }

        // Read / Update
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllAsync() 
        {
            return await _context.Pessoas.ToListAsync();
        }

        [HttpGet ("{userId}")]
        public async Task<ActionResult<User>> GetUserIdAsync(int userId){
            var user = await _context.Pessoas.FindAsync(userId);

            if (user == null)
            {
                return NotFound(); 
            }

            return user;
        }

        // Create
        [HttpPost] 
        public async Task<ActionResult<User>> AddUserAsync (User user) {
            await _context.Pessoas.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // Update
        [HttpPut] 
        public async Task<ActionResult> UpdateUserAsync (User user) {
            _context.Pessoas.Update(user);
            await _context.SaveChangesAsync ();
            return Ok();
        }

        // Delete
        [HttpDelete ("{userId}")]
        public async Task<ActionResult> DeleteUserAsync (int userId) {
            var user = await _context.Pessoas.FindAsync (userId);

            if (user == null)
            {
                return NotFound();
            }

            _context.Remove(user);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}