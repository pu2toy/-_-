using System;
namespace Task02
{
    public class RangeFilter : IFilterStrategy
    {
        private int a { get; set; }
        private int b { get; set; }

        public RangeFilter(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Filter(IEnumerable<int> items)
        {
            Console.WriteLine($"\nЧисла в диапозоне[{a};{b}]: ");
            foreach (int item in items)
            {
                if (item >= a && item <= b)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

