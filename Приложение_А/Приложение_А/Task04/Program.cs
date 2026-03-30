using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите h = ");
        double h = Convert.ToDouble(Console.ReadLine());
        double g = 9.81523;

        double t = Math.Sqrt((2 * h) / g);
        Console.WriteLine($"{t:N2} м/с"); ;
    }
}