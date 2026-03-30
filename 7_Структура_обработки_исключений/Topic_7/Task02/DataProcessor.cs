using System;
namespace Task02
{
    public class DataProcessor
    {
        JsonParser json = new JsonParser();

        public void Catcher(string path)
        {
            try
            {
                json.Parse(path);
            }
            catch (Exception ex)
            {
                Logger(ex);

                throw new Exception("Ошибка при обрабоке JSON файла", ex);
            }
        }

        public void Logger(Exception ex)
        {
            Console.WriteLine("Логирование:");
            Console.WriteLine($"Сообщение: {ex.Message}");
            Console.WriteLine($"Стек: {ex.StackTrace}");

            if (ex.InnerException != null)
            {
                Console.WriteLine("Внутреннее исключение");
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}

