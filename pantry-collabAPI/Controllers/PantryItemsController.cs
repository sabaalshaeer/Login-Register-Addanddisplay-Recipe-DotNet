using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantryItemsController : ControllerBase
    {
        private readonly PantryDbContext _pantry;

        public PantryItemsController(PantryDbContext context)
        {
            _pantry = context;
        }
        // GET: api/Users
        [HttpGet("pantryItemDetails")]
        public ActionResult<List<PantryItem>> GetPantryItemDetails()
        {
            var pantryItemDetails = _pantry.PantryItems.ToList();
            return pantryItemDetails;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PantryItem>> GetPantryById(int id)
        {
            var pantryItem = await _pantry.PantryItems.FindAsync(id);
            if(pantryItem == null)
            {
                return NotFound();
            }

            return pantryItem;

        }
       [HttpGet]
        public async Task<ActionResult<List<PantryItem>>> GetPantryByuserId(int userId)
        {
            var pantryItem = await _pantry.PantryItems
                .Where(p => p.UserId == userId)
                .ToListAsync();
           
            return pantryItem;

        } 

        [HttpPost("{id}")]
        public async Task<ActionResult<Item>> addItemToPantry([FromBody] Item newItemObjinPantry, int id)
        {
            var selectedItem = await _pantry.Items.FindAsync(id);
            if (selectedItem == null)
            {
                return NotFound();
            }

            _pantry.Items.Add(newItemObjinPantry);
            await _pantry.SaveChangesAsync();

            return Ok(newItemObjinPantry);// create new object with message
        }


        [HttpPost("pantryItem")]
        public async Task<ActionResult<PantryItem>> PostPantryItem(PantryItem pantryItemObj)
        {
           
                _pantry.PantryItems.Add(pantryItemObj);
                await _pantry.SaveChangesAsync();
            
            return Ok();// create new object with message
        }

    }
}
