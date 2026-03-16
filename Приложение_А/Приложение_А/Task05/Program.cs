using System;

class Program
{
    public static void Main()
    {
        Console.Write("Вычисление объёма цилиндра\nВведите исходные данные:\nРадиус основания(см) ->");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Высота цилиндра(см) ->");
        double height = Convert.ToDouble(Console.ReadLine());
        double V = Math.PI * Math.Pow(radius, 2) * height;
        Console.Write($"Объём цилиндра {V:N3}");
    }
}