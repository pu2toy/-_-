class Program
{
    public static void Main()
    {
        GetAnimalSound("Dog");
        GetAnimalSound("Cat");
        GetAnimalSound("Cow");
        GetAnimalSound("Dog", "Bark");
        GetAnimalSound("Cat", "Meeeeooooooow");
        GetAnimalSound("Cow", "Crack");
    }

    static void GetAnimalSound(string animal)
    {
        if (animal == "Dog")
        {
            Console.WriteLine("Woof");
        }
        else if (animal == "Cat")
        {
            Console.WriteLine("Meow");
        }
        else if (animal == "Cow")
        {
            Console.WriteLine("Moo");
        }
    }

    static void GetAnimalSound(string animal, string noise)
    {
        if (animal == "Dog")
        {
            Console.WriteLine(noise);
        }
        else if (animal == "Cat")
        {
            Console.WriteLine(noise);
        }
        else if (animal == "Cow")
        {
            Console.WriteLine(noise);
        }
    }
}