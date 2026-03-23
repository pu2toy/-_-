using System;
namespace Task04
{
    public class CoolingSystem
    {
        public void OnChangedTemp(object? sender, EventArgs e)
        {
            Console.WriteLine("Кондиционер в помещении включен.");
        }
    }
}

