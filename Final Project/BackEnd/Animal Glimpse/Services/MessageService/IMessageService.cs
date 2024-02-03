using Animal_Glimpse.Models;
using Animal_Glimpse.Models.Responses;

namespace Animal_Glimpse.Services.MessageService
{
    public interface IMessageService
    {
        Task SendMessageAsync(MessageRequest request);
    }
}
