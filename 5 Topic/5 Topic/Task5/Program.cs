using System;

class Program
{
    static void Main()
    {
        // Ввод числа n с клавиатуры
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine());

        // Вычисление и вывод результата
        double result = CalculateF(n);
        Console.WriteLine($"Результат f({n}) = {result}");
    }

    // Рекурсивная функция для вычисления факториала
    static int Factorial(int n)
    {
        if (n <= 1) return 1; // Базовый случай
        return n * Factorial(n - 1); // Рекурсия
    }

    // Функция для вычисления f(n)
    static double CalculateF(int n)
    {
        int factorial = Factorial(n);
        return (1.0 + factorial) / (2.0 + factorial);
    }
}
