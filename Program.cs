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
            //var services = new ServiceCollection();

            //// Register services
            //services.AddScoped<INotificationService<EmailMessage>, EmailService>();
            //services.AddScoped<INotificationService<SmsMessage>, SmsService>();

            //var serviceProvider = services.BuildServiceProvider();

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}