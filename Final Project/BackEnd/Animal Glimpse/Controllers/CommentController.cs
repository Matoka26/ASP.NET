using Animal_Glimpse.Models;
using Animal_Glimpse.Models.DTOs.CommentDTO;
using Animal_Glimpse.Models.Responses;
using Animal_Glimpse.Services.CommentsService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentsService _commentsService;

        public CommentController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        //[Authorize]
        [HttpPost("AddComm")]
        public async Task<IActionResult> AddComment([FromBody] CommentCreateDTO comm)
        {
            try
            {
                await _commentsService.AddComment(comm);
                return  Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpDelete("DeleteComm")]
        public async Task<IActionResult> DeleteComment([FromBody]Guid id)
        {
            try
            {
                await _commentsService.DeleteComment(id);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Comment was deleted successfully"
                });
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("GetCommentsOnPost")]
        public async Task<IActionResult> GetCommsOfPost(Guid postId)
        {
            try
            {
                return Ok(await _commentsService.GetCommsOfPost(postId));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("GetCommentsOfUser")]
        public async Task<IActionResult> GetCommsOfUser(Guid userId)
        {
            try
            {
                return Ok(await _commentsService.GetCommsOfUser(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPatch("EditComm")]
        public async Task<IActionResult> UpdateComment([FromBody] CommentUpdateDTO comm)
        {
            try
            {
                await _commentsService.UpdateComment(comm);
                return Ok(new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Comment Updated Successfully"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
