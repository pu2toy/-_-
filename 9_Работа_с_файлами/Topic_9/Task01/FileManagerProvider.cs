using System;
using System.IO;

namespace Task01
{
    public class FileManagerProvider
    {
        public void GetInfoFile(string path)
        {
            FileInfo file = new FileInfo(path);
            string date = Convert.ToString(file.CreationTime);
            Console.WriteLine("Дата создания: " + date);
        }

        public long GetSizeFile(string path)
        {
            FileInfo file = new FileInfo(path);
            long size = file.Length;
            Console.WriteLine("Размер файла: " + size);
            return size;
        }

        public void GetLastChangeFile(string path)
        {
            FileInfo file = new FileInfo(path);
            string lastChange = Convert.ToString(file.LastWriteTime);
            Console.WriteLine("Последнее изменение: " + lastChange);

        }
    }
}

