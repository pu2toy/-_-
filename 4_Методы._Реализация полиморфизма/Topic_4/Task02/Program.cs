class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите число A: ");
        float a = (float)Convert.ToDouble(Console.ReadLine());

        float b, c, d;
        PowerA234(a, out b, out c, out d);
        Console.WriteLine($"Степень числа: {a :N4},\nВторая степень: {b:N4},\nТретья степень:" +
            $" {c:N4},\nЧетвертая степень: {d:N4}.");
    }

    static void PowerA234(float a, out float b, out float c, out float d)
    {
        b = a * a;
        c = a * a * a;
        d = a * a * a * a;
    }
}