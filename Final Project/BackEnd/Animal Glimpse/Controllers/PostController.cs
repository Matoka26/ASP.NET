using Animal_Glimpse.Services.PostService;
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
    }
}
