class Program
{
    public static void Main()
    {
        Console.Write("Введите размерность матрицы(N < 10): ");
        int N = Convert.ToInt32(Console.ReadLine());
        while (N > 9)
        {
            Console.WriteLine("Введите корректное значение N: ");
            N = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nВведите диапазон значений[a, b]\na = ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        int[,] numbers = GenerateArray(N, a, b);
        Console.WriteLine();
        PrintArray(numbers, N);
        int sum = SumOfNegative(numbers, N);
        Console.WriteLine("Сумма отрицательных чисел: " + sum);
        CountOfEvens(numbers, N);
    }

    static int[,] GenerateArray(int N, int a, int b)
    {
        Random random = new Random();
        int[,] numbers = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                numbers[i, j] = random.Next(a, b);
            }
        }
        return numbers;
    }

    static void PrintArray(int[,] numbers, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int SumOfNegative(int[,] numbers, int N)
    {
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (numbers[i,j] < 0)
                {
                    sum += numbers[i, j];
                }
            }
        }

        return sum;
    }

    static void CountOfEvens(int[,] numbers, int N)
    {
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            count = 0;
            for(int j = 0; j < N; j++)
            {
                if (numbers[i,j] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество чётных в {0} строке: {1}", i, count);
        }
    }
}