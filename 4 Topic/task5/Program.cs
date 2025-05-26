using System;

class Program
{
    // Метод для вычисления первого выражения: y = arctg(x) / (x - 3)
    static double CalculateExpression1(double x)
    {
        if (x == 3)
            throw new DivideByZeroException("Невозможно делить на 0: x - 3 = 0.");

        return Math.Atan(x) / (x - 3);
    }

    // Метод для вычисления второго выражения: y = ln(x) + (5x - 3) / (x - 1)
    static double CalculateExpression2(double x)
    {
        if (x <= 0)
            throw new ArgumentException("Невозможно вычислить ln(x): x должен быть положительным.");
        if (x == 1)
            throw new DivideByZeroException("Невозможно делить на 0: x - 1 = 0.");

        return Math.Log(x) + (5 * x - 3) / (x - 1);
    }

    static void Main()
    {
        try
        {
            Console.Write("Введите значение x для первого выражения: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            double result1 = CalculateExpression1(x1);
            Console.WriteLine($"Результат первого выражения: y = {result1:F4}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение x.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }

        Console.WriteLine();

        try
        {
            Console.Write("Введите значение x для второго выражения: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            double result2 = CalculateExpression2(x2);
            Console.WriteLine($"Результат второго выражения: y = {result2:F4}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение x.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
