using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : Controller
    {
        private readonly PantryDbContext _recipe;
        public RecipesController(PantryDbContext context)
        {
            _recipe = context;
        }

        [HttpPost("Postrecipe")]
        public async Task<ActionResult<List<Recipe>>> CreatRecipes([FromBody] Recipe request)
        {
            var user = await _recipe.Users.FindAsync(request.UserId);
            if (user == null)
            {
                return NotFound();
            }
            var newRecipe = new Recipe
            {
                UserId = user.Id,
                Name = request.Name,
                Url = request.Url,
                Ingredients = request.Ingredients,
                Steps = request.Steps,
            };

            _recipe.Recipes.Add(newRecipe);
            await _recipe.SaveChangesAsync();

            return await GetRecipes((int)newRecipe.UserId);
            // return Ok(newRecipe);
        }

        [HttpGet]
        public async Task<ActionResult<List<Recipe>>> GetRecipes(int userId)
        {
            var recipes = await _recipe.Recipes
                .Where(r => r.UserId == userId)
                .Include(r => r.Ingredients)
                .Include(r => r.Steps)
                .ToListAsync();
            return recipes;
        }
    }
}
