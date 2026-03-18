class Program
{
    public static void Main()
    {
        int[][] array = new int[3][];
        array[0] = new int[3] { 1, 2, 3 };
        array[1] = new int[4] { 3, 4, 5, 6 };
        array[2] = new int[2] { 15, 1 };

        int max = 0;
        int row = 0;
        for (int i = 0; i < 3; i++)
        {
            int sum = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
            }
            if (sum > max)
            {
                max = sum;
                row = i + 1;
            }
        }

        Console.WriteLine("Строка с наибольшей суммой: " + row);
    }
}