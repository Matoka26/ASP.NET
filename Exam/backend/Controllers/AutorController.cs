using backend.Models.DTOs;
using backend.Services.AutorService;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorService _autorservice;

        public AutorController(IAutorService autorservice)
        {
            _autorservice = autorservice;
        }

        [HttpGet("AllAuthors")]
        public async Task<IActionResult> GetEditures()
        {
            try
            {
                return Ok(await _autorservice.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateAutor")]
        public async Task<IActionResult> CreateAutor([FromBody] AutorDTO autor)
        {
            try
            {
                await _autorservice.CreateAutor(autor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
