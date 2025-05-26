using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        var matches = Regex.Matches(Console.ReadLine(), @"[^\w\s]+");

        Console.WriteLine(matches.Count > 0
            ? "Слова из символов пунктуации:\n" + string.Join("\n", matches)
            : "Не найдено слов из символов пунктуации.");
    }
}