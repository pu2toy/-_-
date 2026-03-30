using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    public class DebitCardFactory : BankCardFactory
    {
        public override IBankCard CreateCard()
        {
            return new DebitCard();
        }
    }
}
