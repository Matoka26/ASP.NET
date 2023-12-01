using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tema4.Services.UserService;

namespace Tema4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetUserByUsername([FromBody] string username) 
        {
            return Ok(_userService.GetUserByUsername(username));
        }
    }
}
