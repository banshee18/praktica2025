using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для обработки последовательности вещественных чисел.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// Вводит последовательность чисел, записывает их в файл, выполняет обработку и выводит результаты.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Обработка последовательности вещественных чисел");
        Console.WriteLine("----------------------------------------------");

        try
        {
            /// <summary>
            /// Запрашивает у пользователя количество чисел для ввода.
            /// </summary>
            Console.Write("Введите количество чисел: ");
            int n = int.Parse(Console.ReadLine());

            /// <summary>
            /// Массив для хранения введенных вещественных чисел.
            /// </summary>
            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                /// <summary>
                /// Запрашивает у пользователя очередное число.
                /// </summary>
                Console.Write($"Введите число #{i + 1}: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            /// <summary>
            /// Путь к файлу, в который записываются введенные числа.
            /// </summary>
            string filePath = "numbers.txt";

            /// <summary>
            /// Запись чисел в файл.
            /// </summary>
            File.WriteAllLines(filePath, numbers.Select(x => x.ToString()));

            /// <summary>
            /// Чтение чисел из файла и преобразование их в массив.
            /// </summary>
            double[] fileNumbers = File.ReadAllLines(filePath)
                                     .Select(double.Parse)
                                     .ToArray();

            /// <summary>
            /// Запрашивает число для сравнения и выводит все числа из файла, меньшие данного значения.
            /// </summary>
            Console.Write("\nВведите число для сравнения: ");
            double threshold = double.Parse(Console.ReadLine());

            Console.WriteLine($"Числа меньше {threshold}:");
            foreach (var num in fileNumbers.Where(x => x < threshold))
                Console.WriteLine(num);

            /// <summary>
            /// Выводит все положительные числа из файла.
            /// </summary>
            Console.WriteLine("\nВсе положительные числа:");
            foreach (var num in fileNumbers.Where(x => x > 0))
                Console.WriteLine(num);

            /// <summary>
            /// Вычисляет среднее арифметическое чисел на четных позициях (индексация с 0).
            /// </summary>
            double evenPosAvg = fileNumbers
                .Where((num, index) => index % 2 == 1)
                .Average();

            Console.WriteLine($"\nСреднее арифметическое на четных позициях: {evenPosAvg:F0}");

            /// <summary>
            /// Выводит содержимое файла для наглядности.
            /// </summary>
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(string.Join(", ", fileNumbers));
        }
        catch (FormatException)
        {
            /// <summary>
            /// Обрабатывает ошибку, если вводимые данные не соответствуют числовому формату.
            /// </summary>
            Console.WriteLine("Ошибка: введено некорректное число");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Универсальная обработка ошибок с выводом сообщения.
            /// </summary>
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            /// <summary>
            /// Финальный блок, завершающий выполнение программы.
            /// </summary>
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
