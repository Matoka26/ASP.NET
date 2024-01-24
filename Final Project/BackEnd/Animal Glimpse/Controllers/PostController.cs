using Animal_Glimpse.Models.DTOs.PostDTO;
using Animal_Glimpse.Models.DTOs.UserDTOs;
using Animal_Glimpse.Services.PostService;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("PostFeed")]
        public async Task<IActionResult> GetFeed()
        {
            try
            {
                return Ok(await _postService.GetFeed());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetPostsByUsername")]
        public async Task<IActionResult> GetPostsByUsername(string username)
        {
            try
            {
                return Ok(await _postService.GetPostsByUsername(username));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NewPost")]
        public async Task<IActionResult> CreatePost(PostCreateDTO post)
        {
            try
            {
                _postService.CreatePost(post);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeletePost")]
        public IActionResult DeletePost(Guid postId)
        {
            try
            {
                _postService.Delete(postId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [HttpPatch("EditPost")]
        public IActionResult EditPost([FromBody]PostUpdateDTO post)
        {
            try
            {
                _postService.UpdatePost(post);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
