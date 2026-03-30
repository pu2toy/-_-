using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    public class CreditCardFactory : BankCardFactory
    {
        public override IBankCard CreateCard()
        {
            return new CreditCard();
        }
    }
}
