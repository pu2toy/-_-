using System;
namespace Task01
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }

        public Task(int id, string title, string priority)
        {
            Id = id;
            Title = title;
            Priority = priority;
        }
    }
}

