class Program
{
    public static void Main()
    {
        int n, m;
        Console.WriteLine("Введите размерность массива:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("*");
        m = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = GenerateArray(n, m);
        PrintArray(numbers, n, m);
        Console.WriteLine("Введите номер строки для проверки?(номер строки < N)");
        int numberRow = Convert.ToInt32(Console.ReadLine());
        int sum = SumOfRow(numbers, numberRow - 1, m);
        Console.WriteLine("Введите число для проверки:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (sum > num)
        {
            Console.WriteLine("Сумма {0} превышает {1}", sum, num);
        }
        else
        {
            Console.WriteLine("Сумма {0} меньше заданного числа {1}", sum, num);
        }
    }

    static int[,] GenerateArray(int N, int M)
    {
        Random random = new Random();
        int[,] numbers = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                numbers[i, j] = random.Next(100);
            }
        }
        return numbers;
    }

    static void PrintArray(int[,] numbers, int N, int M)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int SumOfRow(int[,] numbers, int row, int M)
    {
        int sum = 0;
        for (int i = 0; i < M; i++)
        {
            sum += numbers[row, i];
        }
        return sum;
    }
}