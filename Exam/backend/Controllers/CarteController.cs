using backend.Models.DTOs;
using backend.Repositories.CarteAutorRepository;
using backend.Services.CarteAutorService;
using backend.Services.CarteService;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    public class CarteController : Controller
    {
        private readonly ICarteService _carteservice;
        private readonly ICarteAutorService _relservice;

        public CarteController(ICarteService carteservice, ICarteAutorService ser)
        {
            _carteservice = carteservice;
            _relservice = ser;
        }

        [HttpGet("AllBooks")]
        public async Task<IActionResult> GetBooks()
        {
            try
            {
                return Ok(await _carteservice.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateBook")]
        public async Task<IActionResult> CreateCarte([FromBody]CarteDTO carte)
        {
            try
            {
                await _carteservice.CreateCarte(carte);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AssignAuthor")]
        public async Task<IActionResult> AssignAutor([FromBody]RelatieDTO rel)
        {
            try
            {
                await _relservice.AssignAuthor(rel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
