using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    public interface INotification<T> : IMessage
    {
        void SendMessage(T argument);
    }
}
