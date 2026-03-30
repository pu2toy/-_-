using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("x = 0,5");
        double x = 0.5f;
        double y = x * Math.Pow(Math.E, Math.Pow(x, 2)) - ((Math.Sin(Math.Sqrt(x)) + Math.Pow(Math.Cos(Math.Log(x)), 2)) / (Math.Sqrt(Math.Abs(1 - Math.PI * x))));
        Console.WriteLine($"y = {y:N2}");
    }
}