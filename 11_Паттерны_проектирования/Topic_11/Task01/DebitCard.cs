using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class DebitCard : IBankCard
    {
        public void Use()
        {
            Console.WriteLine("Использована дебетовая карта");
        }
    }
}
