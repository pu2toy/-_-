class Program
{
    public static void Main()
    {
        bool isCorrected;
        Console.Write("Введите число A(A >= 1 и A <= 99) и число B(B > A и B <= 100)\n");
        int a, b, count = 0;
        do
        {
            Console.Write("A = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B = ");
            b = Convert.ToInt32(Console.ReadLine());
            isCorrected = isCorrectNumbers(a, b);
        } while (!isCorrected);

        for (int i = a; i <= b; i++)
        {
            count++;
            Console.WriteLine(i);
        }
        Console.WriteLine("N = " + count);
    }

    static bool isCorrectNumbers(int a, int b)
    {
        if (a < b && a >=1 && b <= 99)
        {
            Console.WriteLine("Данные введены верно");
            return true;
        }
        else
        {
            Console.WriteLine("Введите корректные данные!");
            return false;
        }

    }
}