class Program
{
    public static void Main()
    {
        Console.Write("Введите пару чисел (x, y)\n");
        float x, y;
        float.TryParse(Console.ReadLine(), out x);
        float.TryParse(Console.ReadLine(), out y);
        isPlaceInSecond(x, y);
    }

    static void isPlaceInSecond(float x, float y)
    {
        if ((x < 0) && (y > 0))
        {
            Console.WriteLine("Координаты находятся во второй четверти.");
        }
        else
        {
            Console.WriteLine("Координаты не находятся во второй четверти.");
        }
    }
}