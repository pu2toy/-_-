namespace Task02
{
    class Program
    {
        public static void Main()
        {
            DictionaryManager<int, string> manager = new DictionaryManager<int, string>();

            manager.Add(1, "Alex");
            manager.Add(15, "Leha");

            Console.WriteLine(manager.Find(1));

            manager.Remove(1);
            try
            {
                Console.WriteLine(manager.Find(1));
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}