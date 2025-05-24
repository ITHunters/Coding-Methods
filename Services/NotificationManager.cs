using NotificationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeMethods.Services
{
    // NotificationManager class that manages notifications of type T
    // T is covariant with IMessage interface if method return type need to generic we use NotificationManager<out T>

    internal class NotificationManager<T> where T : IMessage
    {
        public readonly INotification<T> _service;

        // Dependency Inject INotification interface to the constructor
        public NotificationManager(INotification<T> service)
        {
            _service = service;
        }

        public void Notify(T message)
        {
            _service.SendMessage(message);
        }
    }
}
