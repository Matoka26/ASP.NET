using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tema4.Services.ClientService;

namespace Tema4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController: ControllerBase
    {
        private IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetClientByName([FromBody] string name) 
        { 
            return Ok(_clientService.GetClientByName(name));
        }
    }
}
