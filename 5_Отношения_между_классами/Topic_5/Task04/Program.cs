namespace Task04
{
    class Program
    {
        public static void Main()
        {
            NotificationService service = new NotificationService();

            ((ISmsNotifier)service).SendNotification("Привет, мир!");
            ((IEmailNotifier)service).SendNotification("Привет, мир!");
        }
    }
}