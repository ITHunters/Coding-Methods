
using NotificationService;

namespace CleanCodeMethods
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_Notification_Click(object sender, EventArgs e)
        {

            EmailService emailService = new EmailService();
        }

        private void btn_SMS_Click(object sender, EventArgs e)
        {
            SMSService sMSService = new SMSService();
        }
    }
}
