using backend.Models;
using backend.Services.TestService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetTests()
        {
            return Ok(await _testService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTest([FromBody] Test test)
        {
            await _testService.Create(test);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> UpdateTest([FromBody] Test test)
        {
            await _testService.Update(test);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult DeleteTest(Guid id)
        {
            _testService.Delete(id);
            return Ok();
        }
    }
}
