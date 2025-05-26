using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// Выполняет чтение чисел из файла, их фильтрацию и запись результата в другой файл.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Чтение чисел из файла f.txt и преобразование их в массив целых чисел.
            /// </summary>
            int[] numbers = File.ReadAllLines("f.txt")
                           .Select(line => int.Parse(line.Trim()))
                           .ToArray();

            /// <summary>
            /// Фильтрация чисел: оставляет только те, которые делятся на 3, но не делятся на 7.
            /// </summary>
            var filteredNumbers = numbers.Where(n => n % 3 == 0 && n % 7 != 0);

            /// <summary>
            /// Запись отфильтрованных чисел в файл g.txt.
            /// </summary>
            File.WriteAllLines("g.txt", filteredNumbers.Select(n => n.ToString()));

            Console.WriteLine("Обработка завершена. Результат записан в g.txt");
            Console.WriteLine($"Найдено {filteredNumbers.Count()} подходящих чисел.");
        }
        catch (FileNotFoundException)
        {
            /// <summary>
            /// Обработка ошибки: файл f.txt не найден.
            /// </summary>
            Console.WriteLine("Файл f.txt не найден.");
        }
        catch (FormatException)
        {
            /// <summary>
            /// Обработка ошибки: файл содержит некорректные данные.
            /// Ожидаются натуральные числа.
            /// </summary>
            Console.WriteLine("Файл содержит некорректные данные. Ожидаются натуральные числа.");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка других исключений, вывод сообщения об ошибке.
            /// </summary>
            /// <param name="ex">Объект исключения.</param>
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
