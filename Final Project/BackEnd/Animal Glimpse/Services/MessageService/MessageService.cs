using Animal_Glimpse.Models;
using Animal_Glimpse.Models.Responses;
using FirebaseAdmin.Messaging;

namespace Animal_Glimpse.Services.MessageService
{
    public class MessageService : IMessageService
    {
        public async Task SendMessageAsync(MessageRequest request)
        {
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = request.Title,
                    Body = request.Body,
                },
                Token = request.DeviceToken
            };

            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);


            if (string.IsNullOrEmpty(result))
                throw new Exception("Error sending message.");
            
        }
    }
}
