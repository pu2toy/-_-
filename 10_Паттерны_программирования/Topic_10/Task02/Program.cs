namespace Task02
{
    class Program
    {
        public static void Main()
        {
            DataFilter filter = new DataFilter();
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 100);
            filter.SetStrategy(new EvenNumberFilter());
            filter.GetFilter(array);
            filter.SetStrategy(new PrimeNumberFilter());
            filter.GetFilter(array);
            filter.SetStrategy(new RangeFilter(20, 40));
            filter.GetFilter(array);
        }
    }
}