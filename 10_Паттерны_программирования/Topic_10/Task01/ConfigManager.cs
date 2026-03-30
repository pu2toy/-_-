using System;
namespace Task01
{
    public class ConfigManager
    {
        private static ConfigManager? _instance;
        private static readonly object _lock = new object();
        private static Dictionary<string, string> _settings =new Dictionary<string, string>();

        private ConfigManager()
        {
        }

        public void SetConfig(string key, string value)
        {
            _settings[key] = value;
        }

        public string? GetConfig(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : null;
        }

        public static ConfigManager Instance
        {
            get {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigManager();
                    }
                    return _instance;
                }
            }
        }
    }
}

