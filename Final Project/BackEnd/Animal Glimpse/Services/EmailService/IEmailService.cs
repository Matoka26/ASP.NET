using Animal_Glimpse.Models.EmailConfig;

namespace Animal_Glimpse.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
