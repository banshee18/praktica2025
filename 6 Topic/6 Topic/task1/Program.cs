using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сообщение:");
        string message = Console.ReadLine();

        Console.WriteLine("Введите символ для удаления слов:");
        char targetChar = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Переход на новую строку

        // Разбиваем сообщение на слова
        string[] words = message.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Фильтруем слова - оставляем только те, которые НЕ заканчиваются на targetChar
        var filteredWords = words.Where(word => !word.EndsWith(targetChar.ToString()));

        // Собираем отфильтрованное сообщение обратно
        string result = string.Join(" ", filteredWords);

        Console.WriteLine("\nРезультат:");
        Console.WriteLine(result);
    }
}