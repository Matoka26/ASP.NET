using backend.Models.DTOs;
using backend.Services.AutorService;
using backend.Services.EdituraService;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdituraController : Controller
    {
        private readonly IEdituraService _ediService;
        
        public EdituraController(IEdituraService ediService)
        {
            _ediService = ediService;
        }

        [HttpGet("AllEditures")]
        public async Task<IActionResult> GetEditures()
        {
            try
            {
                return Ok(await _ediService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateEditura")]
        public async Task<IActionResult> CreateEditura([FromBody] EdituraDTO editura)
        {
            try
            {
                await _ediService.CreateEditura(editura);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
