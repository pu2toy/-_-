using System;
namespace Task02
{
    public class MyDictionary<TKey, TValue> where TKey : notnull
    {
        private const int _defaultCapacity = 10;
        private List<Entry>[] _list;

        public MyDictionary()
        {
            _list = new List<Entry>[_defaultCapacity];
        }

        private class Entry
        {
            public TKey Key;
            public TValue Value;

            public Entry(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private int GetIndex(TKey key)
        {
            int hash = key.GetHashCode();
            return Math.Abs(hash % _list.Length);
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetIndex(key);

            if (_list[index] == null)
            {
                _list[index] = new List<Entry>();
            }

            foreach (var entry in _list[index])
            {
                if (entry.Key.Equals(key))
                {
                    throw new ArgumentException("Такой ключ уже существует");
                }
            }

            _list[index].Add(new Entry(key, value));
        }

        public void Remove(TKey key)
        {
            int index = GetIndex(key);

            if (_list[index] == null) return;

            for (int i = 0; i < _list[index].Count; i++)
            {
                if (_list[index][i].Key.Equals(key))
                {
                    _list[index].RemoveAt(i);
                    return;
                }
            }
        }

        public TValue Find(TKey key)
        {
            int index = GetIndex(key);
            if (_list[index] != null)
            {
                foreach (var entry in _list[index])
                {
                    if (entry.Key.Equals(key)) return entry.Value;
                }
            }

            throw new KeyNotFoundException();
        }
    }
}

