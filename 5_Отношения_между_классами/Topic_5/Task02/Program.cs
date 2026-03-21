namespace Task02
{
    class Program
    {
        public static void Main()
        {
            Library library = new Library();

            library.GenerateLibrary(15);
            library.DisplayInfo();
            library.SortByName();
            Console.WriteLine("Отсортированная библиотека: ");
            library.DisplayInfo();
        }
    }
}