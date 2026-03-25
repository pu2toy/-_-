using System.Security.Claims;

namespace Task03
{
    class program
    {
        public static void Main()
        {
            IQueue<int> queue = new SimpleQueue<int>();
            QueueManager<int> manager = new QueueManager<int>(queue);

            manager.Add(10);
            manager.Add(20);
            manager.Add(30);

            Console.WriteLine("Очередь:");
            manager.PrintQueue();

            Console.WriteLine($"Первый элемент: {manager.GetFirst()}");

            Console.WriteLine($"Удален: {manager.Remove()}");

            Console.WriteLine("После удаления:");
            manager.PrintQueue();

            Console.WriteLine($"Очередь пуста? {manager.IsEmpty()}");
        }
    }
}