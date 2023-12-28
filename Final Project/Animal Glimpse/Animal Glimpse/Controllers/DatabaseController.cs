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
/*
        [HttpPost("User")]
        public async Task<IActionResult> CreateUser(CreateUserDTO userdto)
        {
            if (userdto == null)
                return BadRequest("Invalid data");

            // Create new user
            var newUser = new User
            {
                // AutoComplete some properties
                Id = Guid.NewGuid(),
                CreatedTime = DateTime.Now,
                LastModifiedTime = DateTime.Now,

                // Complete from DTO
                firstName = userdto.firstName,
                lastName = userdto.lastName,
                username = userdto.username,
                email = userdto.email,
                password = userdto.password,
                phoneNumber = userdto.phoneNumber,
                birthDate = userdto.birthDate,

                // For relationships
                Admin = null,
                Posts = null,
                Commentss = null,
                Reactions = null,
                Profile = new Profile
                {

                }
            };
    

            await _animalcontext.AddAsync(newUser);
            await _animalcontext.SaveChangesAsync();
            
            return Ok(newUser);
        }*/

        [HttpPost("React")]
        public async Task<IActionResult> CreateReact(CreateReactDTO reactdto)
        {
            var newReact = new React
            {
                // Autocompleted
                Id = Guid.NewGuid(),
                CreatedTime = DateTime.Now,
                LastModifiedTime = null,

                // Completed from DTO
                Color = reactdto.Color,
                Name = reactdto.Name,
                Logo = reactdto.Logo
            };

            await _animalcontext.AddAsync(newReact);
            await _animalcontext.SaveChangesAsync();
            
            return Ok(newReact);
        }
    }
}
