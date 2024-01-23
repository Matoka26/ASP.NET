using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Animal_Glimpse.Data;
using Animal_Glimpse.Models;
using Animal_Glimpse.Services.CommentsService;
using Microsoft.AspNetCore.Authorization;
using Animal_Glimpse.Models.DTOs;
using Animal_Glimpse.Models.Responses;
using System;
using Microsoft.AspNetCore.Identity;
using Animal_Glimpse.Models.DTOs.UserDTOs;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;   
        private readonly UserManager<User> _userManager;

        public UserController(IUserService userService, UserManager<User> userManager)
        {
            _userService = userService;
            _userManager = userManager;
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            try {
                return Ok(await _userService.GetUserById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 500,
                    Message = ex.Message
                });
            }
        }

        [AllowAnonymous]
        [HttpPost("signUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDTO signUpDTO)
        {
            try
            {
                await _userService.SignUp(signUpDTO);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "SignUp successful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            try
            {
                return Ok(new LoginResponseDTO()
                {
                    Id = await _userService.Login(login)
                });
            }
            catch (Exception exception)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 500,
                    Message = exception.Message
                });
            }
        }


        [HttpPatch("updateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO user)
        {
            try
            {
                return Ok(await _userService.Update(user));
            }
            catch (Exception exception)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 500,
                    Message = exception.Message
                });
            }
        }

        [HttpDelete("deleteUser")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            try
            {
                await _userService.Delete(id);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "User was deleted successfully"
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 500,
                    Message = ex.Message
                });
            }
        }
    }

}
