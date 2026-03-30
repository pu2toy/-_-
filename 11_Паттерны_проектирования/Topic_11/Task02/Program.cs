namespace Task02
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICoffee coffee = new BasicCoffee();
            coffee = new MilkDecorator(coffee);
            Console.WriteLine(coffee.GetDescription());
            coffee = new SugarDecorator(coffee);
            Console.WriteLine(coffee.GetDescription());
            coffee = new SyrupDecorator(coffee);
            Console.WriteLine(coffee.GetDescription());
        }
    }
}