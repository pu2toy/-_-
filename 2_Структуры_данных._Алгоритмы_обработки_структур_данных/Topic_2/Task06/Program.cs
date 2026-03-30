class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();

        bool hasNumber = false;
        foreach (char c in text)
        {
            if (char.IsDigit(c))
            {
                hasNumber = true;
            }
        }
        Console.WriteLine(hasNumber);
    }
}