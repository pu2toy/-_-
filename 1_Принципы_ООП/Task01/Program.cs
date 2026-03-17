using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите кол-во килограммов - ");
        int kg = Convert.ToInt16(Console.ReadLine());
        FindHundredweight(kg);
    }

    static void FindHundredweight(int kilograms)
    {
        int hw = kilograms / 100;
        Console.WriteLine($"{kilograms} кг = {hw} полных центнеров");
    }
}