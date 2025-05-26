using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Обработка последовательности вещественных чисел");
        Console.WriteLine("----------------------------------------------");

        try
        {
            // 1. Ввод последовательности чисел
            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите число #{i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            // 2. Запись чисел в файл
            string filePath = "numbers.txt";
            File.WriteAllLines(filePath, numbers.Select(x => x.ToString()));

            // 3. Чтение чисел из файла
            double[] fileNumbers = File.ReadAllLines(filePath)
                                     .Select(double.Parse)
                                     .ToArray();

            // a) Вывод чисел меньше заданного
            Console.Write("\nВведите число для сравнения: ");
            double threshold = double.Parse(Console.ReadLine());

            Console.WriteLine($"Числа меньше {threshold}:");
            foreach (var num in fileNumbers.Where(x => x < threshold))
                Console.WriteLine(num);

            // b) Вывод всех положительных чисел
            Console.WriteLine("\nВсе положительные числа:");
            foreach (var num in fileNumbers.Where(x => x > 0))
                Console.WriteLine(num);

            // c) Среднее арифметическое на четных позициях (индексы 1, 3, 5...)
            double evenPosAvg = fileNumbers
                .Where((num, index) => index % 2 == 1) // Четные позиции (индексация с 0)
                .Average();

            Console.WriteLine($"\nСреднее арифметическое на четных позициях: {evenPosAvg:F0}");

            // Вывод содержимого файла для наглядности
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(string.Join(", ", fileNumbers));
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное число");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}