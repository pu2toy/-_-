using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    public class VirtualCardFactory : BankCardFactory
    {
        public override IBankCard CreateCard()
        {
            return new VirtualCard();
        }
    }
}
