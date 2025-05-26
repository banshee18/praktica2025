using System;

class Program
{
    static void Main()
    {
        // Ввод значения x
        double x = -1; // Вы можете изменить значение x для других расчетов.

        // Вычисление значения уравнения
        double y = CalculateEquation(x);

        // Вывод результата
        Console.WriteLine($"Результат уравнения при x = {x}: y = {y:F4}");
    }

    static double CalculateEquation(double x)
    {
        // Вычисление значения подкоренного выражения
        double innerExpression = Math.Exp(x) + 1;

        // Проверка, что подкоренное выражение положительное
        if (innerExpression < 0)
        {
            throw new ArgumentException("Ошибка: подкоренное выражение должно быть положительным.");
        }

        // Вычисление значения y
        double y = 7 * Math.Pow(Math.Atan(Math.Sqrt(innerExpression) + Math.Abs(x)), 2);
        return y;
    }
}
