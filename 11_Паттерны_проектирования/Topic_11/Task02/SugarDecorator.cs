using System;
using System.Collections.Generic;
using System.Text;

namespace Task02
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + " + сахар";
        }
    }
}
