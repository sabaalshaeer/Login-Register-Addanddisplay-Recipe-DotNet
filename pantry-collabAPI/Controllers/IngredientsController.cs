using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly PantryDbContext _ingredient;
        public IngredientsController(PantryDbContext context)
        {
            _ingredient = context;
        }

        [HttpGet("IngredientDetails")]
        public async Task<ActionResult<List<Ingredient>>> GetIngredientDetails()
        {
            var ingredientDetails = _ingredient.Ingredients.ToListAsync();
            return await ingredientDetails;
        }


            [HttpGet("{id}")]
            public async Task<ActionResult<Ingredient>> GetIngredientById(int id)
            {
            var ingredient = await _ingredient.Ingredients.FindAsync(id);
                    if (ingredient == null)
            {
                return NotFound();
            }
                return ingredient;

            }
            // POST: api/
            [HttpPost]
        public async Task<ActionResult<Ingredient>> PostIngredient(Ingredient ingredientObj)
        {
            if (ingredientObj == null)
            {
                return BadRequest();
            }
            else
            {
                _ingredient.Ingredients.Add(ingredientObj);
                await _ingredient.SaveChangesAsync();
            }
            return Ok();// create new object with message
        }
    }
}
