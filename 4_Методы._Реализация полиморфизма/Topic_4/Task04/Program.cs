namespace Task04
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число для проверки: ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(num.IsEven());
        }
    }
}