using System;
using System.Collections.Generic;
using System.Text;

namespace Task02
{
    public class BasicCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Чёрный кофе";
        }

        public double GetCost()
        {
            return 2.1;
        }
    }
}