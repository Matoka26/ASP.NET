using Animal_Glimpse.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /*        [HttpGet]
                public IActionResult GetUserByUsername ([FromBody] string username)
                {
                    return Ok(_userService.)
                }*/
        [HttpGet]
        public IActionResult GetUsersSorted()
        {
            return Ok(_userService.GetUsersSorted());
        }
    }
}
