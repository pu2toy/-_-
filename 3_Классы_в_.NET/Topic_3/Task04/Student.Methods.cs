using System;
using Bogus;

namespace Task04
{
    public partial class Student
    {
        public static Student GenerateStudent()
        {
            var faker = new Faker<Student>("ru")
                .RuleFor(s => s.Name, f => f.Name.FirstName())
                .RuleFor(s => s.Group, f => f.Random.Int(38, 46))
                .RuleFor(s => s.GPA, f => f.Random.Float(0.5f, 5f));
            Student s = faker.Generate();
            return s;
        }

        public int GetGroup()
        {
            return Group;
        }

        public float GetGPA()
        {
            return GPA;
        }

        public string? GetName()
        {
            return Name;
        }
    }
}

