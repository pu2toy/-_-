using System;
using System.IO;

namespace Task01
{
    public class FileManager
    {
        public void CreateFile(string path) 
        {
            File.Create(path).Close();
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public void CopyFile(string path, string copy)
        {
            File.Copy(path, copy);
        }

        public void TransperentFile(string path, string to)
        {
            File.Move(path, to);
        }
    }
}

