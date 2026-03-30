using System;
using System.Collections.Generic;
using System.Text;

namespace Task01
{
    class VirtualCard : IBankCard
    {
        public void Use()
        {
            Console.WriteLine("Использована виртуальная карта");
        }
    }
}
