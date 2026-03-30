namespace Task01
{
    class Program
    {
        public static void Main()
        {
            FileManager manager = new FileManager();
            FileManagerProvider provider = new FileManagerProvider();
            manager.CreateFile("/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/input.txt");
            FileInfo file = new FileInfo("/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/input.txt");
            File.WriteAllText(file.FullName, "Hello world!");
            Console.WriteLine(File.ReadAllText(file.FullName));
            provider.GetInfoFile(file.FullName);
            provider.GetSizeFile(file.FullName);
            string copyFile = "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/input_copy.txt";
            if (!File.Exists(copyFile))
            {
                manager.CopyFile(file.FullName, copyFile);
            }
            
            if (File.Exists(copyFile))
            {
                Console.WriteLine("Файл существет.");
            }
            if (!File.Exists("/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/input_copy_moved.txt"))
            {
                manager.TransperentFile(copyFile, "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/input_copy_moved.txt");
            }
            if (!File.Exists("/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/Макарчук.БВ"))
            {
                File.Move(file.FullName, "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/Макарчук.БВ");
            }
            if (provider.GetSizeFile(file.FullName) == provider.GetSizeFile(copyFile))
            {
                Console.WriteLine("Файлы равны");
            }
            else
            {
                Console.WriteLine("Файлы не равны по размеру");
            }
            string directory = "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9";

            string[] files = Directory.GetFiles(directory, "*.БВ");
            string[] allFiles = Directory.GetFiles(directory);
            string path = "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/input.txt";
            string path1 = "/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/input.txt";

            FileAttributes attr = File.GetAttributes(path1);

            if ((attr & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("Файл только для чтения");
            }
            else
            {
                Console.WriteLine("Файл доступен для записи");
            }
            File.SetAttributes(path, FileAttributes.ReadOnly);

            try
            {
                File.WriteAllText(path, "Новый текст");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Запись запрещена: файл только для чтения");
            }
            foreach (string f in allFiles)
            {
                Console.WriteLine(f);
            }
            foreach (string f in files)
            {
                File.Delete(f);
            }
            try
            {
                if (File.Exists(file.FullName))
                {
                    manager.DeleteFile(file.FullName);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}