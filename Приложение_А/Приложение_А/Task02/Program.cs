class Program
{
    public static void Main()
    {
        Console.Write("Введите 4-значное число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int result = (a / 1000) * (a / 100) * (a / 10) * (a % 10);
        Console.WriteLine(result);
    }
}