using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите a: ");
        double a = Convert.ToDouble(Console.Read());
        double z1 = (1 - 2 * Math.Pow(Math.Sin(a), 2)) / (1 + Math.Sin(2 * a));
        double z2 = (1 - Math.Tan(a)) / (1 + Math.Tan(a));
        Console.WriteLine($"z1 = {z1:N2}\nz2 = {z2:N2}");
    }
}