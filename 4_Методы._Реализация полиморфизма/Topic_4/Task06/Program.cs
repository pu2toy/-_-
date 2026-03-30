class Program
{
    public static void Main()
    {
        int h = 1, m = 20, s = 54;
        IncTime(ref h, ref m, ref s, 3600);
        Console.WriteLine($"Время: {h} часов {m} минут {s} секунд");
    }

    static void IncTime (ref int h, ref int m, ref int s, int t)
    {
        int time = s + (m * 60) + (h * 3600) + t;
        h = time / 3600;
        m = (time / 60) % 60;
        s = time % 60;
    }
}