using System;

class Program
{
    // Метод для вычисления значения функции f(x)
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

    // Метод для построения таблицы значений функции
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
