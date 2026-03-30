using System;
namespace Task03
{
    public class StockMarket
    {
        Random rnd = new Random();
        List<IStockObserver> _investors = new List<IStockObserver>();

        public void Subscribe(IStockObserver investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IStockObserver investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IStockObserver investor in _investors)
            {
                if (rnd.Next(0, 2) == 1)
                {
                    investor.CostIsChanged("увеличилась");
                }
                else
                {
                    investor.CostIsChanged("уменьшилась");
                }
            }
        }
    }
}

