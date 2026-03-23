using System;
namespace Task04
{
    public class AlarmSystem
    {
        public void OnChangedTemp(object? sender, EventArgs e)
        {
            Console.WriteLine("Внимание! Температура была изменена!");
        }
    }
}

