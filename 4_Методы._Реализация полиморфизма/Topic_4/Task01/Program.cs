class Program
{
    public static void Main()
    {
        int[] numbers = new int[32];
        GenerateArray(numbers);
        PrintArray(numbers);
        Console.WriteLine("Сумма элементов: " + SumOfArray(numbers));
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[" + array[i] + "] ");
        }
        Console.WriteLine();
    }

    static void GenerateArray(int[] array)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(-50, 50);
        }
    }

    private static long SumOfArray(int[] array)
    {
        long sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
}