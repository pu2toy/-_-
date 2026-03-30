class Program
{
    public static void Main()
    {
        string text = Console.ReadLine();

        string[] words = text.Split(' ');
        Dictionary<string, int> count = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }

        string mostWord = "";
        int max = 0;

        foreach (var word in count)
        {
            if (word.Value > max)
            {
                max = word.Value;
                mostWord = word.Key;
            }
        }

        Console.WriteLine("Самое частое слово: " + mostWord);
        Console.WriteLine("Количество: " + max);
    }
}