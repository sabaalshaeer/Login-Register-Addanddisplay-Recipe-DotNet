using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pantry_collabAPI.Data;
using pantry_collabAPI.Models;

namespace pantry_collabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepsController : Controller
    {

        private readonly PantryDbContext _context;
        public StepsController(PantryDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Step>>> GetSteps()
        {
            var steps = await _context.Steps.ToListAsync();
            return steps;
        }

        [HttpPost("id")]
        public async Task<ActionResult<Step>> CreateStep(Step step)
        {
            _context.Steps.Add(step);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSteps), new { stepId = step.Id }, step);
        }

        [HttpPost]
        public async Task<ActionResult<Step>> PostStep(Step stepObj)
        {
           
                _context.Steps.Add(stepObj);
                await _context.SaveChangesAsync();
            
            return Ok(stepObj);// create new object with message
        }
    }
}
