using NotificationService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public class SMSService : INotification<SMSDTO>
    {
        public SMSService() { }

        public void SendMessage(SMSDTO argument)
        {
           Console.WriteLine("SMS sent");
        }
    }
}
