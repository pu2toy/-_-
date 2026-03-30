using System;

class Program
{
    public static void Main()
    {
        int x = 5;
        double y = Math.Pow(Math.E, 2 * x) - Math.Pow(Math.E, Math.Sqrt(Math.Abs(1 - x))) + (2 * Math.Pow(Math.Sin(x), 2))/(Math.PI * Math.Pow(x, 2));
        Console.WriteLine($"Результат: {y:N3}");
    }
}