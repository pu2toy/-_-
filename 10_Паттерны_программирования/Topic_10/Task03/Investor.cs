using System;
namespace Task03
{
    public class Investor : IStockObserver
    {
        private string _name;
        public Investor(string name)
        {
            _name = name;
        }

        public void CostIsChanged(string message)
        {
            Console.WriteLine($"Инвестор {_name}, акция {message} в цене");
        }
    }
}

