using System;
using System.Collections;

namespace Task01
{
    public class TaskManager
    {
        Queue<Task> Tasks = new Queue<Task>();

        public void AddTask(Task task)
        {
            Tasks.Enqueue(task);
        }

        public void ProcessTask()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("Нет активных задач");
                return;
            }

            var task = Tasks.Dequeue();
            Console.WriteLine("Операция была выполнена и удалена из очереди "
                + task.Id + " " + task.Priority + " " + task.Title);
        }

        public Task[] GetPendingTasks()
        {
            return Tasks.ToArray();
        }
    }
}

