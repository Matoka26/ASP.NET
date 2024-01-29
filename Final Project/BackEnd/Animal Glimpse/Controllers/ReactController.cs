using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.ReactDTO;
using Animal_Glimpse.Models.Responses;
using Animal_Glimpse.Services.ReactService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        private readonly IReactService _reactService;
        public ReactController(IReactService reactService)
        {
            _reactService = reactService;
        }

        [HttpGet("GetReacts")]
        public async Task<IActionResult> GetReacts()
        {
            try
            {
                return Ok(await _reactService.GetAllReacts());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateReact")]
        public async Task<IActionResult> CreateReact([FromBody] ReactCreateDTO react)
        {
            try
            {
                await _reactService.CreateReact(react);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "React created successfully"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteReact")]
        public async Task<IActionResult> DeleteReact([FromBody] Guid id)
        {
            try
            {
                await _reactService.DeleteReact(id);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "React deleted successfully"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("UpdateReact")]
        public async Task<IActionResult> UpdateReact([FromBody] ReactUpdateDTO react)
        {
            try
            {
                await _reactService.UpdateReact(react);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "React updated successfully"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
