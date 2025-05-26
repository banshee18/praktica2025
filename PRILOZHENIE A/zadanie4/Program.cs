using System;

class Program
{
    static void Main()
    {
        try
        {
            // Ввод значений сторон трапеции
            Console.Write("Введите сторону A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону C: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону D: ");
            double d = Convert.ToDouble(Console.ReadLine());

            // Проверка корректности введённых данных
            if (a <= 0 || b <= 0 || c <= 0 || d <= 0)
            {
                Console.WriteLine("Ошибка: все стороны должны быть положительными числами.");
                return;
            }

            // Вычисление полупериметра
            double p = (a + b + c + d) / 2;

            // Вычисление абсолютной разницы между сторонами A и B
            double absDifference = Math.Abs(a - b);

            // Проверка условий существования трапеции
            if (p - a <= 0 || p - b <= 0 || p - a - c <= 0 || p - a - d <= 0)
            {
                Console.WriteLine("Ошибка: стороны трапеции не удовлетворяют условиям существования.");
                return;
            }

            // Вычисление площади трапеции
            double area = ((a + b) / 4) * absDifference * Math.Sqrt((p - a) * (p - b) * (p - a - c) * (p - a - d));

            // Вывод результата
            Console.WriteLine($"\nПлощадь трапеции: {area:F4}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: ввод должен быть числовым.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
