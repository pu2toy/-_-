using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class RobotVacuum
    {
        public void StartCleaning()
        {
            Console.WriteLine("Пылесос начал уборку.");
        }

        public void StopCleaning() 
        { 
            Console.WriteLine("Пылесос остановился."); 
        }

        public void ReturnToBase()
        {
            Console.WriteLine("Пылесос вернуля на базу.");
        }
    }
}
