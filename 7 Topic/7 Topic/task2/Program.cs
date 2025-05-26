using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main() => Console.WriteLine(
        Regex.Matches(Console.ReadLine() ?? "", @"\b[Аа]\w*\b", RegexOptions.IgnoreCase) is { Count: > 0 } m
            ? $"Слова на 'А/а':\n{string.Join("\n", m)}"
            : "Не найдено слов на 'А/а'");
}