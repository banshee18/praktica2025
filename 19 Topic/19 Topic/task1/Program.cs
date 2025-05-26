using System;

class Program
{
    /// <summary>
    /// Вычисляет значение функции f(x) в зависимости от параметров
    /// </summary>
    /// <param name="x">Аргумент функции</param>
    /// <param name="a">Параметр a - граничное значение</param>
    /// <param name="b">Параметр b - коэффициент в формуле</param>
    /// <returns>
    /// Возвращает значение функции:
    /// - -1, если x < a
    /// - (x - b)/(x + b), если x > a
    /// - 1 + tan(x), если x == a
    /// </returns>
    static double CalculateFunction(double x, double a, double b)
    {
        if (x < a)
        {
            return -1;
        }
        else if (x > a)
        {
            return (x - b) / (x + b);
        }
        else // x == a
        {
            return 1 + Math.Tan(x);
        }
    }

    /// <summary>
    /// Строит таблицу значений функции f(x) на интервале [a, b] с шагом h
    /// </summary>
    /// <param name="a">Начало интервала</param>
    /// <param name="b">Конец интервала</param>
    /// <param name="h">Шаг изменения аргумента</param>
    /// <remarks>
    /// Выводит в консоль таблицу с двумя колонками: x и f(x)
    /// Значения округляются до 4 знаков после запятой
    /// </remarks>
    static void BuildTable(double a, double b, double h)
    {
        Console.WriteLine("\nТаблица значений функции f(x):");
        Console.WriteLine("x\tf(x)");

        for (double x = a; x <= b; x += h)
        {
            double fx = CalculateFunction(x, a, b);
            Console.WriteLine($"{x:F4}\t{fx:F4}");
        }
    }

    /// <summary>
    /// Главный метод программы
    /// </summary>
    /// <remarks>
    /// Запрашивает у пользователя параметры a, b и h,
    /// проверяет их корректность и выводит таблицу значений функции
    /// </remarks>
    static void Main()
    {
        // Ввод параметров a, b и h
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение h (шаг): ");
        double h = Convert.ToDouble(Console.ReadLine());

        // Проверка корректности ввода
        if (h <= 0 || a > b)
        {
            Console.WriteLine("Ошибка: шаг должен быть положительным, а значение a должно быть меньше или равно b.");
            return;
        }

        // Построение таблицы значений функции
        BuildTable(a, b, h);
    }
}