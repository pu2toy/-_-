class Program
{
    public static void Main()
    {
        int num = 80;
        Console.WriteLine("Вывод с помощью do-while");
        do
        {
            Console.WriteLine($"{num}");
            num -= 2;
        } while (num >= 10);

        num = 80;
        Console.WriteLine("Вывод с помощью while");
        while (num >= 10)
        {
            Console.WriteLine($"{num}");
            num -= 2;
        }

        num = 80;
        Console.WriteLine("Вывод с помощью for");
        for (int i = num; i >= 10; i -= 2)
        {
            Console.WriteLine($"{i}");
        }
    }
}