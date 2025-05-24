using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService
{
    // generic Interface INotification<T> that extends IMessage interface for generic DTO object
    public interface INotification<T> : IMessage
    {
        void SendMessage(T argument);
    }
}
