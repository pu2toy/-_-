using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int result = (num / 10) * (num % 10);
        Console.WriteLine($"Результат: {result}");
    }
}