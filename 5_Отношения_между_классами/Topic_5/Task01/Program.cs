using System.Linq;

namespace Task01
{
    class Program
    {
        public static void Main()
        {
            Animal[] animals = new Animal[10];
            GenerateArray(animals);
            PrintArray(animals);
            Animal[] sorted = animals.OrderBy(x => x.GetType().Name).ToArray();
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(sorted);
            Console.WriteLine("Отфильтрованный массив по названию 'Cow'");
            FiltredArray(animals, "Cow");
        }

        static void GenerateArray(Animal[] animals)
        {
            Random rnd = new Random();
            for (int i = 0; i < animals.Length; i++)
            {
                byte val = (byte)rnd.Next(0, 3);
                if (val == 0)
                {
                    animals[i] = new Dog();
                }
                else if (val == 1)
                {
                    animals[i] = new Cat();
                }
                else
                {
                    animals[i] = new Cow();
                }
            }
        }

        static void PrintArray(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }

        static void FiltredArray(Animal[] animals, string type)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].GetType().Name.ToString() == type)
                {
                    animals[i].MakeSound();
                }
            }
        }
    }
}