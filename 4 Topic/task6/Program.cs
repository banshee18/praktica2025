using System;

class Program
{
    static double CalculateFunction(double x)
    {
        // Проверка условий выхода за диапазон
        if (x <= 0 || x > 10) // Задаём диапазон, например, (0, 10]
        {
            throw new ArgumentOutOfRangeException("x", "Значение x должно быть в диапазоне (0, 10].");
        }

        // Вычисление значения функции
        if (x > 0 && x < 1)
        {
            return x * Math.Cos(x); // x * cos(x) при 0 < x < 1
        }
        else if (x >= 1)
        {
            if (Math.Abs(3 * x - 3) < 0.000001) // Проверка деления на ноль
            {
                throw new DivideByZeroException("Знаменатель в выражении равен нулю.");
            }
            return 12 / (3 * x - 3); // 12 / (3x - 3) при x >= 1
        }

        throw new InvalidOperationException("Неизвестное состояние функции.");
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine()); // Чтение значения x

            // Вычисление значения функции
            double result = CalculateFunction(x);
            Console.WriteLine($"Результат функции f({x}) = {result:F6}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение. Ожидалось вещественное число.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
