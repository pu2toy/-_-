using System;
namespace Task04
{
    public class NotificationService : IEmailNotifier, ISmsNotifier
    {
        void ISmsNotifier.SendNotification(string message)
        {
            Console.WriteLine("Смс-сообщение: " + message);
        }

        void IEmailNotifier.SendNotification(string message)
        {
            Console.WriteLine("Email сообщение: " + message);
        }
    }
}

