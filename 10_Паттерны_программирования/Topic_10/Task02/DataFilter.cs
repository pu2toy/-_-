using System;
namespace Task02
{
    public class DataFilter
    {
        IFilterStrategy? _strategy;

        public void SetStrategy(IFilterStrategy strategy)
        {
            _strategy = strategy;
        }

        public void GetFilter(IEnumerable<int> items)
        {
            _strategy!.Filter(items);
        }
    }
}

