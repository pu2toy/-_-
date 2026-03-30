class Program
{
    public static void Main()
    {
        Console.Write("Введите а=");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b=");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a + "+" + b + "=" + b + "+" + a);
    }
}