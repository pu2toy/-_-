using System;
namespace Task02
{
    public class EvenNumberFilter : IFilterStrategy
    {
        public void Filter(IEnumerable<int> items)
        {
            Console.Write("\nЧётные числа: ");
            foreach (var item in items)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

