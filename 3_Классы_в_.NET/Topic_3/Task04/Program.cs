namespace Task04
{
    class Program
    {
        public static void Main()
        {
            University university = new University();
            university.GenerateGroups(9);
            university.PrintStudents();
            Console.WriteLine("Студенты 43 группы");
            university.PrintArray(university.GetStudentsByGroup("43"));
            Console.WriteLine("Лучшие студенты: ");
            university.GetTopStudent();
        }
    }
}