namespace Task01
{
    class Program
    {
        public static void Main()
        {
            TaskManager manager = new TaskManager();

            manager.AddTask(new Task(1, "My PC", "High"));
            manager.AddTask(new Task(2, "Chrome", "Medium"));
            manager.AddTask(new Task(3, "Music", "Low"));
            manager.ProcessTask();
            Task[] array = manager.GetPendingTasks();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].Id + " " + array[i].Title + " "
                    + array[i].Priority);
            }
            manager.ProcessTask();
        }
    }
}