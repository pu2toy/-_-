using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Task02
{
    public class JsonParser
    {
        public void Parse(string json)
        {
            if (!Regex.IsMatch(json, @"\.json$", RegexOptions.IgnoreCase))
            {
                throw new JsonException("Неверный путь к файлу");
            }
        }
    }
}

