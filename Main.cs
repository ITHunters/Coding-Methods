
using CleanCodeMethods.Services;
using NotificationService;
using NotificationService.DTO;

namespace CleanCodeMethods
{
    public partial class Main : Form
    {
        
        INotification<SMSDTO> smsManager;
        public Main(INotification<SMSDTO> _smsManager)
        {
            InitializeComponent();
            this.smsManager = _smsManager;
        }

        private void btn_Notification_Click(object sender, EventArgs e)
        {

            // Fix: Create an instance of EmailDTO with the correct properties
            // but properties are readonly cannot initialize only initialize in constructor

            //var email = new EmailDTO
            //{
            //    To = "to@example.com",
            //    Subject = "Hello",
            //    Body = "Test body",
            //    From = "from@example.com"
            //};

            // Fix: Use the correct generic type for INotification
            // Injection Dependancy Injection Manually

            INotification<EmailDTO> emailnotification = new EmailService();
            NotificationManager<EmailDTO> notificationManager = new NotificationManager<EmailDTO>(emailnotification);
            
            // Data Transfer Objects (DTOs) for Email and SMS

            EmailDTO email = new EmailDTO("abcd@gmail.com", "abcd@gmail.com", "WHO", "Message Text","Regards Haroon Siddique");
            SMSDTO sms = new SMSDTO("0305361597", "Mesage");


            notificationManager.Notify(email);
            smsManager.SendMessage(sms);
        }

        private void btn_SMS_Click(object sender, EventArgs e)
        {
            SMSService sMSService = new SMSService();
        }
    }
}
