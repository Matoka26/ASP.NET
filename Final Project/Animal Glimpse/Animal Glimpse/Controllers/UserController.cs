using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Services.CommentsService;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;   
    
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsersSorted()
        {
            return Ok( _userService.GetAllSorted());
        }
    }

}
