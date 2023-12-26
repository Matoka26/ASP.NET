using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Tema3.Data;

namespace Tema3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public DatabaseController(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Movies.ToListAsync());
        }
    }
}
