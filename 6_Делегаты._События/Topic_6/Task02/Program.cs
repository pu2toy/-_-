class Program
{
    delegate int MathOperation(int a, int b);

    public static void Main()
    {
        Calculate(15, 20, Add);
        Calculate(15, 20, Multiply);
    }

    static void Calculate(int a, int b, MathOperation operation)
    {
        Console.WriteLine("Результат вычислений: " + operation(a, b));
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}