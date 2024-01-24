using Animal_Glimpse.Models.DTOs.ProfileDTO;
using Animal_Glimpse.Models.Responses;
using Animal_Glimpse.Services.ProfileService;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;
        
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpPost("CreateProfile")]
        public async Task<IActionResult> CreateProfile(ProfileCreateDTO profile)
        {
            try
            {
                await _profileService.CreateProfile(profile);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProfile")]
        public async Task<IActionResult> GetProfileByUsername(string username)
        {
            try
            {
                return Ok(await _profileService.GetProfileByUsername(username));
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }

        [HttpPatch("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile([FromBody] ProfileUpdateDTO profile)
        {
            try
            {
                await _profileService.UpdateProfile(profile);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new ErrorResponse()
                {
                    StatusCode = 400,
                    Message = ex.Message
                });
            }
        }
    }
}
