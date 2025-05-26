using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Запрос ввода текста у пользователя
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        // Регулярное выражение для поиска слов с хотя бы одной цифрой
        string pattern = @"\b\w*\d\w*\b";

        // Поиск совпадений
        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Слова, содержащие хотя бы одну цифру:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("Не найдено слов, содержащих цифры.");
        }
    }
}
