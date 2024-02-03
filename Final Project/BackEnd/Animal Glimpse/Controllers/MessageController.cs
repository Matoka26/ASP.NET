using Animal_Glimpse.Models;
using Animal_Glimpse.Services.MessageService;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Glimpse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        public IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost("SendMessage")]
        public async Task<IActionResult> SendMessageAsync([FromBody] MessageRequest request)
        {
            try
            {
                await _messageService.SendMessageAsync(request);
                return Ok("Message sent successfully!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
