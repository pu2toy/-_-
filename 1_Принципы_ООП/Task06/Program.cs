class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

        switch (year % 12)
        {
            case 0:
                Console.WriteLine("Год обезьяны.");
                break;
            case 1:
                Console.WriteLine("Год петуха.");
                break;
            case 2:
                Console.WriteLine("Год собаки.");
                break;
            case 3:
                Console.WriteLine("Год свиньи.");
                break;
            case 4:
                Console.WriteLine("Год крысы.");
                break;
            case 5:
                Console.WriteLine("Год быка.");
                break;
            case 6:
                Console.WriteLine("Год тигра.");
                break;
            case 7:
                Console.WriteLine("Год кролика.");
                break;
            case 8:
                Console.WriteLine("Год дракона.");
                break;
            case 9:
                Console.WriteLine("Год змеи.");
                break;
            case 10:
                Console.WriteLine("Год лошади.");
                break;
            case 12:
                Console.WriteLine("Год козы.");
                break;
        }
    }
}