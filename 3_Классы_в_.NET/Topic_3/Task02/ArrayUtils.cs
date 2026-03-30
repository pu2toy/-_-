using System;
using Bogus;

namespace Task02
{
    public static class ArrayUtils
    {
        public static int countPersons { get; set; }

        public static Person[] SortByName(Person[] persons)
        {
            Array.Sort(persons, (p1, p2) => String.Compare(p1.name, p2.name, StringComparison.CurrentCultureIgnoreCase));
            return persons;
        }

        public static void PrintArray(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] != null)
                    Console.WriteLine(persons[i].name + ", " + persons[i].age + "лет.");
            }
        }

        public static Person[] FilterByAge(Person[] persons, int age)
        {
            Person[] filtredPersons = new Person[10];
            int positionInArray = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].age == age)
                {
                    filtredPersons[positionInArray] = persons[i];
                    positionInArray++;
                    if (positionInArray >= filtredPersons.Length)
                    {
                        Array.Resize(ref filtredPersons, filtredPersons.Length * 2);
                    }
                }

            }
            if (positionInArray == 0)
            {
                Console.WriteLine("Нет людей такого возраста");
                return Array.Empty<Person>();
            }
            else
            {
                return filtredPersons.Take(positionInArray).ToArray();
            }
        }

        public static Person GeneratePerson()
        {
            var personFaker = new Faker<Person>("ru")
                .RuleFor(p => p.name, f => f.Name.FirstName())
                .RuleFor(p => p.age, f => f.Random.Int(18, 60));
            var person = personFaker.Generate();
            return person;
        }

        public static void GetCount(Person[] persons)
        {
            countPersons = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] != null)
                {
                    countPersons++;
                }
            }
            Console.WriteLine("Количество людей: " + countPersons);
        }
    }
}

