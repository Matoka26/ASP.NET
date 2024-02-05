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
using Animal_Glimpse.Services.EmailService;
using Animal_Glimpse.Models.EmailConfig;
using FirebaseAdmin.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;   
        private readonly UserManager<User> _userManager;
        private readonly IEmailService _emailService;

        public UserController(IUserService userService, UserManager<User> userManager, IEmailService emailService)
        {
            _userService = userService;
            _userManager = userManager;
            _emailService = emailService;
        }

        [HttpGet("GetUserById")]
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

        [HttpGet("GetUserByUsername")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            try
            {
                return Ok(await _userService.GetUserByUsername(username));
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
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpDTO signUpDTO)
        {
            try
            {
                var subject = "Test";
                var content = "SignUp successfull";
                var message = new Models.EmailConfig.Message(new string[]{signUpDTO.Email}, subject, content);
                

                _emailService.SendEmail(message);

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
        [Authorize]
        [HttpPost("LogOut")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _userService.Logout();
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Logout Successful"
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

        [HttpPatch("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO user)
        {
            try
            {
                await _userService.Update(user);
                return Ok();
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

        [HttpDelete("DeleteUser")]
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
