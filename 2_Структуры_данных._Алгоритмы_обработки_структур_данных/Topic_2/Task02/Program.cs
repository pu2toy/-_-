class Program
{
    public static void Main()
    {
        int[] numbers = new int[50];
        numbers = GenerateArray();
        Console.WriteLine("Исходный массив: ");
        PrintArray(numbers);
        int num = numbers[49];
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != num)
            {
                count++;
            }
        }
        Console.WriteLine("\nЧисел отличных от последнего: " + count);
        Console.WriteLine("\nСортировка массива: ");
        Array.Sort(numbers);
        PrintArray(numbers);
        Console.WriteLine("\nВведите число которое хотите найти в массиве: ");
        int k = Convert.ToInt32(Console.ReadLine());
        if (Array.BinarySearch(numbers, k) > -1)
        {
            Console.WriteLine("Число найдено на позиции: " + Array.BinarySearch(numbers, k));
        }
        else
        {
            Console.WriteLine("Такого числа нет в массиве");
        }
    }

    static int[] GenerateArray()
    {
        int[] array = new int[50];
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100);
        }
        return array;
    }

    static void PrintArray(int[] numbers)
    {
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}