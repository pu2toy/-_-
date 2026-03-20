class Program
{
    public static void Main()
    {
        double f;
        ConvertCelsiumToFahrenheit(25, out f);
        Console.WriteLine(f + "°F");
        ConvertKelvinToFahrenheit(273, out f);
        Console.WriteLine(Math.Round(f, 7) + "°F");
    }

    static void ConvertCelsiumToFahrenheit(in double celsius, out double fahrenheit)
    {
        fahrenheit = (celsius * (9 / 5)) + 32;
    }

    static void ConvertKelvinToFahrenheit(in double kelvin, out double fahrenheit)
    {
        fahrenheit = ((kelvin - 273.15) * (9 / 5)) + 32;
    }
}