namespace Task03
{
    class Program
    {
        public static void Main()
        {
            OrderStatusManager manager = new OrderStatusManager();
            CustomerNotifier customer = new CustomerNotifier();
            AdminLogger admin = new AdminLogger();

            manager.statusChanged += customer.OnEvent;
            manager.statusChanged += admin.OnChangedStatus;

            manager.PlaceOrder();
        }
    }
}