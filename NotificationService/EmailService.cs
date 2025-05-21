using NotificationService.DTO;

namespace NotificationService
{
    public class EmailService : INotification<EmailDTO>
    {
        public EmailService() { }
        public void SendMessage(EmailDTO argument)
        {
            Console.WriteLine("Email sent");
        }
    }
}
