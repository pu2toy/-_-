using System;
using System.IO;

namespace Task04
{
    public class FileWatcher
    {
        FileSystemWatcher watcher;
        private string backupFolder;

        public FileWatcher(string folderToWatch, string backupFolder)
        {
            this.backupFolder = backupFolder;

            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            watcher = new FileSystemWatcher(folderToWatch);
            watcher.IncludeSubdirectories = false;
            watcher.NotifyFilter = NotifyFilters.FileName |
                NotifyFilters.LastWrite | NotifyFilters.Size;

            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Файл переименован: {e.OldFullPath} -> {e.FullPath}");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл {e.FullPath} был удалён.");
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл был изменен: {e.FullPath}");
            CreateBackup(e.FullPath);
        }

        private void CreateBackup(string fullPath)
        {
            if (!File.Exists(fullPath)) return;

            string fileName = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string backupFileName = $"{fileName}_{timestamp}.{extension}";
            string backupPath = Path.Combine(backupFolder, backupFileName);

            try
            {
                File.Copy(fullPath, backupPath, true);
                Console.WriteLine($"Создана резервная копия: {backupPath}");
            } catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при создании резервной копии: {ex.Message}");
            }
        }
        
        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Файл был создан: {e.FullPath}");
        }
    }
}
