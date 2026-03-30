namespace Task01
{
    public class Program
    {
        public static void Main()
        {
            var config = ConfigManager.Instance;
            config.SetConfig("theme", "dark");
            config.SetConfig("language", "en");
            config.SetConfig("User", "boga");
            config.SetConfig("Main Browser", "FireFox");

            Console.WriteLine("Конфиг(theme): " + ConfigManager.Instance.GetConfig("theme"));
            Console.WriteLine("Конфиг(lang): " + config.GetConfig("language"));
            Console.WriteLine("Конфиг(User): " + config.GetConfig("User"));
            Console.WriteLine("Конфиг(Browser): " + config.GetConfig("Main Browser"));
        }
    }
}