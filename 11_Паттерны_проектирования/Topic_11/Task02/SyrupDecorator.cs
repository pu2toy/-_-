using System;
using System.Collections.Generic;
using System.Text;

namespace Task02
{
    public class SyrupDecorator : CoffeeDecorator
    {
        public SyrupDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " + сироп";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }
    }
}
