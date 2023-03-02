using Microsoft.AspNetCore.Mvc;
using pantry_collabAPI.test.Interfaces;
using pantry_collabAPI.test.Models;

namespace pantry_collabAPI.test.Controllers
{
    public class MyModelController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class MyModelsController : ControllerBase
        {//5th:  inject the IMyService interface, and use it to call the GET method
            private readonly IMyService _myService;
            public MyModelsController(IMyService myService)

            {
                _myService = myService;

            }

            [HttpGet("{id}")]
            public async Task<ActionResult<List<MyModel>>> GetMethod(int id)
            {
                try
                {
                    var myModel = await _myService.MyGetMethod(id);
                    return Ok(myModel);
                }
                catch (Exception e)
                {

                    return BadRequest(e.Message);
                }
            }
        }
    }
}
