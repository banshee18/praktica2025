using System;

class Program
{
    // Метод SubMod для двух чисел
    static double SubMod(double a, double b)
    {
        return Math.Abs(a - b);
    }

    // Перегруженный метод SubMod для трёх чисел
    static double SubMod(double a, double b, double c)
    {
        return Math.Abs(a - b - c);
    }

    static void Main()
    {
        // Ввод вещественных параметров a1, b1, a2, b2, c2
        Console.Write("Введите значение a1: ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение a2: ");
        double a2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение c2: ");
        double c2 = Convert.ToDouble(Console.ReadLine());

        // Вычисление результатов
        double result1 = SubMod(a1, b1);
        double result2 = SubMod(a2, b2, c2);
        double finalResult = result1 * result2;

        // Вывод результатов
        Console.WriteLine($"\nSubMod(a1, b1): {result1:F3}");
        Console.WriteLine($"SubMod(a2, b2, c2): {result2:F3}");
        Console.WriteLine($"Результат произведения: {finalResult:F3}");
    }
}
