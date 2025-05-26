using System;

/// <summary>
/// Главный класс программы, содержащий методы для вычисления модуля разности чисел
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет модуль разности двух чисел
    /// </summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <returns>Модуль разности a и b (|a - b|)</returns>
    /// <example>
    /// Пример использования:
    /// <code>
    /// double result = SubMod(5.2, 3.1); // вернет 2.1
    /// </code>
    /// </example>
    static double SubMod(double a, double b)
    {
        return Math.Abs(a - b);
    }

    /// <summary>
    /// Вычисляет модуль разности первого числа и суммы двух других
    /// </summary>
    /// <param name="a">Первое число</param>
    /// <param name="b">Второе число</param>
    /// <param name="c">Третье число</param>
    /// <returns>Модуль разности a и суммы b и c (|a - b - c|)</returns>
    /// <example>
    /// Пример использования:
    /// <code>
    /// double result = SubMod(10.0, 3.0, 2.0); // вернет 5.0
    /// </code>
    /// </example>
    static double SubMod(double a, double b, double c)
    {
        return Math.Abs(a - b - c);
    }

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <remarks>
    /// Программа запрашивает у пользователя 5 вещественных чисел,
    /// вычисляет два значения SubMod (для 2-х и 3-х чисел),
    /// перемножает результаты и выводит их на экран.
    /// Все результаты выводятся с точностью до 3 знаков после запятой.
    /// </remarks>
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