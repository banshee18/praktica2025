using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Запрос ввода текста у пользователя
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        // Регулярное выражение для поиска слов, состоящих только из букв, разделённых точками
        string pattern = @"\b(?:[A-Za-z]\.)+[A-Za-z]\b";

        // Поиск совпадений
        MatchCollection matches = Regex.Matches(text, pattern);

        if (matches.Count > 0)
        {
            Console.WriteLine("Слова, состоящие только из букв, разделённых точками:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("Не найдено слов, состоящих только из букв, разделённых точками.");
        }
    }
}
