using System;
using Bogus;

namespace Task02
{
    public class Library
    {
        public Book[] Books = null!;

        public void DisplayInfo()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine("Книга " + (i + 1));
                Console.WriteLine($"Название: {Books[i].Name}");
                Console.Write("Автор(-ы):");
                foreach (Author author in Books[i].Authors)
                {
                    Console.Write($" {author.Name},");
                }
                Console.WriteLine($"\nСодержание: {Books[i].Content.Content}");
            }
        }

        public void GenerateLibrary(int count)
        {
            var authorFaker = new Faker<Author>("ru")
                .RuleFor(a => a.Name, f => f.Name.FullName());
            var contentFaker = new Faker<TableOfContents>("ru")
                .RuleFor(c => c.Content, f => f.Lorem.Sentence());
            var faker = new Faker<Book>("ru")
                .RuleFor(b => b.Name, f => f.Lorem.Sentence(3))
                .RuleFor(b => b.Authors, f => authorFaker.Generate(f.Random.Int(1, 3)).ToArray())
                .RuleFor(b => b.Content, f => contentFaker.Generate());

            Books = faker.Generate(count).ToArray();
        }

        public void SortByName()
        {
            Array.Sort(Books, (x, y) => x.Name.CompareTo(y.Name));
        }
    }
}

