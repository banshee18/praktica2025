using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ввод строки
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Ввод длины слов для поиска
        Console.WriteLine("Введите длину слов для поиска (n):");
        int n = int.Parse(Console.ReadLine());

        // Разделение строки на слова (игнорируя пустые строки)
        var words = input.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '(', ')' },
                              StringSplitOptions.RemoveEmptyEntries);

        // Фильтрация слов по длине и сортировка по алфавиту
        var filteredWords = words.Where(word => word.Length == n)
                               .OrderBy(word => word);

        // Вывод результата
        Console.WriteLine($"\nСлова длиной {n} букв в алфавитном порядке:");
        foreach (var word in filteredWords)
        {
            Console.WriteLine(word);
        }
    }
}