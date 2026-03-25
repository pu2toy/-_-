using System;

namespace Task03
{
    public class QueueManager<T>
    {
        private readonly IQueue<T> _queue;

        public QueueManager(IQueue<T> queue)
        {
            _queue = queue;
        }

        public void Add(T item)
        {
            _queue.Enqueue(item);
        }

        public T Remove()
        {
            return _queue.Dequeue();
        }

        public T GetFirst()
        {
            return _queue.Peek();
        }

        public bool IsEmpty()
        {
            if (_queue is SimpleQueue<T> simpleQueue)
            {
                return simpleQueue.Count == 0;
            }

            throw new InvalidOperationException("Unknown queue type");
        }

        public void PrintQueue()
        {
            if (_queue is SimpleQueue<T> simpleQueue)
            {
                foreach (var item in simpleQueue.GetItems())
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Cannot print queue");
            }
        }
    }
}

