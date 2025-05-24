using Microsoft.Extensions.DependencyInjection;
using NotificationService;
using NotificationService.DTO;
using System.Net.Mail;

namespace CleanCodeMethods
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Register services
             services.AddSingleton<INotification<SMSDTO>, SMSService>();

            // Register Form
             services.AddTransient<Main>();

            
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // Build provider
            var provider = services.BuildServiceProvider();

            // Run app
            ApplicationConfiguration.Initialize();
            var form = provider.GetRequiredService<Main>();
            Application.Run(form);
        }
    }
}