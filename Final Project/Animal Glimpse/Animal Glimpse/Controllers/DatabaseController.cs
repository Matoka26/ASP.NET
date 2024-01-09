using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Animal_Glimpse.Data;
using Animal_Glimpse.Models;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DatabaseController: ControllerBase
    {
        private readonly AnimalContext _animalcontext;

        /// GETS
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

        [HttpGet("Comments")]
        public async Task<IActionResult> GetComments()
        {
            return Ok(await _animalcontext.Commentss.ToListAsync());
        }

        [HttpGet("Reaction")]
        public async Task<IActionResult> GetReactions()
        {
            return Ok(await _animalcontext.Reactions.ToListAsync());
        }

        /// CREATE



    }
}
