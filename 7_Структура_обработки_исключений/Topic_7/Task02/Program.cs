namespace Task02
{
    class Program
    {
        public static void Main()
        {
            DataProcessor data = new DataProcessor();

            try
            {
                data.Catcher("C:/ProgrammFiles/Jsons/Data.png");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Логирование в main: ");
                Console.WriteLine($"Ошибка: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Причина: {ex.InnerException.Message}");
                }
            }
        }
    }
}