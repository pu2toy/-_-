class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"Число {num} чётное");
        }
        else
        {
            Console.WriteLine($"Число {num} нечётное");
        }
    }
}