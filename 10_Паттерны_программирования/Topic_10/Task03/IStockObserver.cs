using System;
namespace Task03
{
    public interface IStockObserver
    {
        public void CostIsChanged(string message);
    }
}

