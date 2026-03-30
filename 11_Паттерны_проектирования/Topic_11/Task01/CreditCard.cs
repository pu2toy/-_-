using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class CreditCard : IBankCard
    {
        public void Use()
        {
            Console.WriteLine("Использова кредитная карта");
        }
    }
}
