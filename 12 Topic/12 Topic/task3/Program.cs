using System;

class Program
{
    // 1. Метод для подсчета количества слов в строке
    static int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // 2. Метод для обращения строки
    static string ReverseString(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // 3. Метод для поиска самого длинного слова
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

    // Объявляем делегат для работы со строками
    delegate void StringOperation(string text);

    static void Main()
    {
        Console.WriteLine("Введите строку для обработки:");
        string input = Console.ReadLine();

        // Создаем экземпляр делегата и добавляем методы
        StringOperation stringOps = null;
        stringOps += text => Console.WriteLine($"Количество слов: {CountWords(text)}");
        stringOps += text => Console.WriteLine($"Перевернутая строка: {ReverseString(text)}");
        stringOps += text => Console.WriteLine($"Самое длинное слово: '{FindLongestWord(text)}'");

        // Вызываем все методы через делегат
        stringOps(input);
    }
}