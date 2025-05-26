using System;

/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Метод для подсчета количества слов в строке.
    /// </summary>
    /// <param name="text">Входная строка для анализа.</param>
    /// <returns>Количество слов в строке.</returns>
    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    /// <summary>
    /// Метод для переворачивания строки задом наперед.
    /// </summary>
    /// <param name="text">Входная строка.</param>
    /// <returns>Перевернутая строка.</returns>
    static string ReverseString(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Метод для поиска самого длинного слова в строке.
    /// </summary>
    /// <param name="text">Входная строка.</param>
    /// <returns>Самое длинное слово.</returns>
    static string FindLongestWord(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return "";

        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
                longestWord = word;
        }

        return longestWord;
    }

    /// <summary>
    /// Делегат для операций со строками.
    /// </summary>
    /// <param name="text">Обрабатываемая строка.</param>
    delegate void StringOperation(string text);

    /// <summary>
    /// Основной метод программы.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите строку для обработки:");
        string input = Console.ReadLine();

        /// <summary>
        /// Экземпляр делегата, включающий методы обработки строк.
        /// </summary>
        StringOperation stringOps = null;
        stringOps += text => Console.WriteLine($"Количество слов: {CountWords(text)}");
        stringOps += text => Console.WriteLine($"Перевернутая строка: {ReverseString(text)}");
        stringOps += text => Console.WriteLine($"Самое длинное слово: '{FindLongestWord(text)}'");

        // Вызываем все методы через делегат
        stringOps(input);
    }
}
