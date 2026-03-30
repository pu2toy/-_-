using System;
namespace Task02
{
    public class PrimeNumberFilter : IFilterStrategy
    {
        public void Filter(IEnumerable<int> items)
        {
            Console.WriteLine("\nПростые числа: ");
            foreach (int item in items)
            {
                bool isPrime = true;
                for (int i = 2; i < item; i++)
                {
                    if (item % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}

