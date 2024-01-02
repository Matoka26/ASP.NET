using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Animal_Glimpse.Data;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DatabaseController: ControllerBase
    {
        private readonly AnimalContext _animalcontext;

        public DatabaseController(AnimalContext animalContext)
        {
            _animalcontext = animalContext;
        }

        [HttpGet("User")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _animalcontext.Users.ToListAsync());
        }

        [HttpGet("React")]
        public async Task<IActionResult> GetReacts()
        {
            return Ok(await _animalcontext.Reacts.ToListAsync());
        }

        [HttpGet("Posts")]
        public async Task<IActionResult> GetPosts()
        {
            return Ok(await _animalcontext.Posts.ToListAsync());
        }
        [HttpGet("Roles")]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(await _animalcontext.Roles.ToListAsync());
        }

    }
}
