using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly PantryDbContext _context;
        public ItemsController(PantryDbContext context)
        {
            _context = context;
        }

        [HttpGet("ItemDetails")]
        public async Task<ActionResult<List<Item>>> GetItemDetails()
        {
            var itemDetails = _context.Items.ToListAsync();
            return await itemDetails;
        }

       


        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemById(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;

        }
       
        
        // POST: api/
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item itemObj)

        { 
            if (itemObj == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Items.Add(itemObj);
                await _context.SaveChangesAsync();
            }
            return Ok(await _context.Items.ToListAsync());// create new object with message
        }

        // POST: api/
        [HttpPost("SentToPantry")]
        public async Task<ActionResult<Item>> PostItemToPantry(Item itemObj)

        {
            if (itemObj == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Items.Add(itemObj);
                await _context.SaveChangesAsync();
            }
            return Ok();// create new object with message
        }

        /*    [HttpPost("{id}")]
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
            }*/
    }
  








    /*private readonly PantryDbContext _mainItem;
    public ItemsController(PantryDbContext context)
    {
        _mainItem = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetAllItems()
    {
        return await _mainItem.Items.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Item>> GetItemById(int id)
    {
        var item = await _mainItem.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        return item;

    }
    // POST: api/
    [HttpPost]
    public async Task<ActionResult<Item>> PostItem(Item itemObj)
    {
        if (itemObj == null)
        {
            return BadRequest();
        }
        else
        {
            _mainItem.Items.Add(itemObj);
            await _mainItem.SaveChangesAsync();
        }
        return Ok();// create new object with message
    }*/
}


    //IActionResult is an interface, we can create a custom response as a return,
    //when you use ActionResult you can return only predefined ones for returning a View or a resource.
    //With IActionResult we can return a response,
    //or error as well. On the other hand, ActionResult is an abstract class, and you would need to make a custom class that inherits.

