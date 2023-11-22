using Tema4.Controllers.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tema4.Models.DTOs;
using Tema4.Models.One_to_Many;

namespace Tema4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly Tema4Context _tema4Context;

        public DatabaseController(Tema4Context tema4Context)
        {
            _tema4Context = tema4Context;
        }

        [HttpGet("model1")]
        public async Task<IActionResult> GetModel1()
        {
            return Ok(await _tema4Context.Models1.ToListAsync());
        }

        [HttpPost("model1")]
        public async Task<IActionResult> Create(Model1DTOs model1dto)
        {
            var newModel1 = new Model1();
            newModel1.id = Guid.NewGuid();
            newModel1.numar = model1dto.numar;

            await _tema4Context.AddAsync(newModel1);
            await _tema4Context.SaveChangesAsync();

            return Ok(newModel1);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Model1DTOs model1dto)
        {
            Model1 modelById = await _tema4Context.Models1.FirstOrDefaultAsync(x => x.id == model1dto.Id);
            if(modelById == null)
            {
                return BadRequest("Object not found");
            }
            modelById.numar = model1dto.numar;
            _tema4Context.Update(modelById);
            await _tema4Context.SaveChangesAsync();

            return Ok(modelById);

        }
    }
}
