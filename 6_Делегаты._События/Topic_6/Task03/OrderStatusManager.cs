using System;
namespace Task03
{
    public delegate void StatusChanged();

    public class OrderStatusManager
    {
        public event StatusChanged? statusChanged;

        public void PlaceOrder()
        {
            statusChanged?.Invoke();
        }
    }
}

