using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //the Asp.net core Identity build in class,
        //and they provide the related methods to manage 
        private readonly PantryDbContext _context;

        public AuthController(PantryDbContext context)
        {
            _context = context;
        }
        // GET: api/Users
        [HttpGet("usersInfo")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var usersDetails = await _context.Users.ToListAsync();
            if(usersDetails == null)
            {
                return BadRequest();
            }
            return usersDetails;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetUserById(int id)
        {
            var users = await _context.Users
                .Where(u => u.Id == id)
                .Include(u => u.Recipes)
                .ToListAsync();
            return users;

        }

        [HttpPost("signup")]
        public async Task<ActionResult<User>> SignUp(User user)
        {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            
            return Ok(new { Message = "Signup Successfully!" });// create new object with message
        }
        
        [HttpGet("login")]
        public async Task<ActionResult<User>> UserAuth(string UserName, string Password)
        {
            var userObj = await _context.Users.FirstOrDefaultAsync(u => u.UserName == UserName && u.Password == Password);
            if (userObj != null)
            {
              //  return Ok(new { Message = "Logged In Successfully", UserData = userObj.FullName ,id = userObj.Id });
            return Ok(userObj);
            }
            else
            {
                return NotFound(new { Message = "User Not Found" });

            }
        }
    }
}
