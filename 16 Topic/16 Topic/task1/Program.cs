using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Чтение чисел из файла f.txt
            int[] numbers = File.ReadAllLines("f.txt")
                           .Select(line => int.Parse(line.Trim()))
                           .ToArray();

            // Фильтрация чисел: делятся на 3 и не делятся на 7
            var filteredNumbers = numbers.Where(n => n % 3 == 0 && n % 7 != 0);

            // Запись результата в файл g.txt
            File.WriteAllLines("g.txt", filteredNumbers.Select(n => n.ToString()));

            Console.WriteLine("Обработка завершена. Результат записан в g.txt");
            Console.WriteLine($"Найдено {filteredNumbers.Count()} подходящих чисел.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл f.txt не найден.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Файл содержит некорректные данные. Ожидаются натуральные числа.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}