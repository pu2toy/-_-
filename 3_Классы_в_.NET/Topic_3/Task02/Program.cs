namespace Task02
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите количество людей, которое вы хотите добавить:");
            int count = Convert.ToInt32(Console.ReadLine());
            Person[] persons = new Person[count];

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = ArrayUtils.GeneratePerson();
            }
            ArrayUtils.GetCount(persons);
            ArrayUtils.PrintArray(persons);
            Console.WriteLine("Отсортированный массив:");
            Person[] sorted = ArrayUtils.SortByName(persons);
            ArrayUtils.PrintArray(sorted);
            Console.WriteLine("Фильтрация(введите возраст):");
            int age = Convert.ToInt32(Console.ReadLine());
            Person[] filtred = ArrayUtils.FilterByAge(persons, age);
            ArrayUtils.PrintArray(filtred);
        }
    }
}