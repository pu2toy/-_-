namespace Task01
{
    class Program
    {
        public static void Main(string[] args)
        {
            A newObject = new A(15, 6);

            Console.WriteLine("Разность равна: " + newObject.Difference());
            Console.WriteLine("Значение выражения (a + b)/(a - b) равно: " + newObject.Expression());
        }
    }
}