using System;
using System.Collections.Generic;

namespace Task03
{
    public class SimpleQueue<T> : IQueue<T>
    {
        private Queue<T> _queue = new Queue<T>();
        public int Count => _queue.Count;

        public void Enqueue(T item)
        {
            _queue.Enqueue(item);
        }

        public T Dequeue()
        {
            return _queue.Dequeue();
        }

        public T Peek()
        {
            return _queue.Peek();
        }

        public IEnumerable<T> GetItems()
        {
            return _queue;
        }
    }
}

