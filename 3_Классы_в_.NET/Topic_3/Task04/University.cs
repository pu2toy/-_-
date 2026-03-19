using System;
namespace Task04
{
    public class University
    {
        Student[] students = new Student[1];

        public void GenerateGroups(int count)
        {
            Array.Resize(ref students, count * 25);
            for (int i = 0; i < count * 25; i++) 
            {
                students[i] = Student.GenerateStudent();
            }
        }

        public void GetTopStudent()
        {
            List<Student> excellents = new List<Student>();
            foreach (Student s in students)
            {
                float avgMark = s.GetGPA();
                if ( avgMark > 4.5f)
                {
                    excellents.Add(s);
                }
            }

            foreach(Student s in excellents)
            {
                Console.WriteLine($"Имя: {s.GetName()}, Группа: {s.GetGroup()}, Средняя оценка: {s.GetGPA()}");
            }
        }

        public List<Student> GetStudentsByGroup(string group)
        {
            List<Student> Group = new List<Student>();
            foreach (Student s in students) 
            {
                if (s.GetGroup().ToString() == group)
                {
                    Group.Add(s);
                }
            }

            return Group;
        }

        public void PrintStudents()
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"Имя: {s.GetName()}, Группа: {s.GetGroup()}, Средняя отметка: {s.GetGPA()}");
            }
        }

        public void PrintArray(List<Student> studs)
        {
            foreach (Student s in studs)
            {
                Console.WriteLine($"Имя: {s.GetName()}, Группа: {s.GetGroup()}, Средняя отметка: {s.GetGPA()}");
            }
        }
    }
}

