class Program
{
    public static void Main()
    {
        int pos = 6;
        Console.WriteLine($"Число Фибоначчи на позиции {pos}: " + Fibonacci(pos));
    }

    static int Fibonacci(int pos)
    {
        if (pos == 1)
        {
            return 1;
        }
        else if (pos == 0)
        {
            return 0;
        }
        else
        {
            return Fibonacci(pos - 1) + Fibonacci(pos - 2);
        }
    }
}