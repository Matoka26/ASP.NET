using Animal_Glimpse.Models.DTOs.ReactionDTO;
using Animal_Glimpse.Models.Responses;
using Animal_Glimpse.Services.ReactionService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {
        private readonly IReactionService _reactionService;
        public ReactionController(IReactionService reactionService)
        {
            _reactionService = reactionService;
        }

        [HttpPost("ReactToPost")]
        public async Task<IActionResult> ReactToPost([FromBody] ReactionCreateDTO reaction)
        {
            try
            {
                await _reactionService.ReactToPost(reaction);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Reaction successful"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteReaction")]
        public async Task<IActionResult> DeleteReaction([FromBody] ReactionDeleteDTO reaction)
        {
            try
            {
                await _reactionService.DeleteReaction(reaction);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Reaction deleted successfully"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetReactionsOfPost")]
        public async Task<IActionResult> GetReactionsOfPost(Guid postId)
        {
            try
            {
                return Ok(await _reactionService.GetReactionsOfPost(postId));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
