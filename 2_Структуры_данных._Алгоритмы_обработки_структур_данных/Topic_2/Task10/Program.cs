using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        string email = Console.ReadLine();
        bool isCorrect = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Console.WriteLine(isCorrect);
    }
}