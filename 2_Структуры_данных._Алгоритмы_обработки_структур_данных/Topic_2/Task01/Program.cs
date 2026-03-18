class Program
{
    public static void Main()
    {
        double[] nums = { Math.PI, Math.Sqrt(2), 5, 10, Math.E, (Math.Sqrt(Math.PI) / 2) };
        int countOfNums = nums.Length;
        double sum = nums.Sum();
        Console.WriteLine("Количество элементов: {0}\nСумма: {1:N4}", countOfNums, sum);
    }
}