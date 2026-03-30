namespace Task05
{
    class Program
    {
        public static void Main()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            cat.MakeSound();
            cat.Sleep();
            dog.MakeSound();
            dog.Sleep();
        }
    }
}