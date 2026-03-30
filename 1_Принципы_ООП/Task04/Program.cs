using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double y;
        if (x >= 10)
        {
            y = 4 + Math.Pow(x, 2) - Math.Pow(Math.E, Math.Sqrt(x));
            Console.WriteLine($"y = {y:N3}");
        }
        else
        {
            y = 3.4 - x + 0.1 * Math.Pow(x, 3);
            Console.WriteLine("y = " + y);
        }
    }
}