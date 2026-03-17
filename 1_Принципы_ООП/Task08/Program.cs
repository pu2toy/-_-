using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число N(1 <= N <= 20): ");
        int n = Convert.ToInt32(Console.ReadLine());
        double result = 0;
        float num = -1.1f;

        for (int i = 1; i < n; i++)
        {
            result += Math.Pow(-1, i) * num;
            Console.Write($"+({(Math.Pow(-1, i) * num):N4})");
            num -= 0.1f;
        }
        Console.WriteLine($"={result:N4}");
    }
}