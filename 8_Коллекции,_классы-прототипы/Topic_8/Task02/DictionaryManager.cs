using System;
namespace Task02
{
    public class DictionaryManager<TKey, TValue> where TKey : notnull
    {
        private readonly MyDictionary<TKey, TValue> _dictionary;

        public DictionaryManager()
        {
            _dictionary = new MyDictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _dictionary.Add(key, value);
        }

        public void Remove(TKey key)
        {
            _dictionary.Remove(key);
        }

        public TValue Find(TKey key)
        {
            TValue value = _dictionary.Find(key);
            return value;
        }
    }
}

