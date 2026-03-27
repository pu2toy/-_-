using System;

namespace Task02
{
    public interface IFilterStrategy
    {
        public void Filter(IEnumerable<int> items);
    }
}

