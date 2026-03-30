namespace Task04
{
    class Program
    {
        public static void Main()
        {
            string toWatch = "/Users/boga/Desktop";
            string backupFolder = "/Users/boga/Desktop/backup";

            FileWatcher watcher = new FileWatcher(toWatch, backupFolder);

            Console.WriteLine("Наблюдение начато...");
            Console.ReadKey();
        }
    } 
}