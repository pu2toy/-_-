using System.Text;

class Program
{
    public static void Main()
    {
        string m1 = Console.ReadLine();
        string m2 = Console.ReadLine();
        StringBuilder sb = new StringBuilder(m1);

        sb.Append(m2);
        Console.WriteLine(sb);
    }
}