using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Создание файла с 5 строками различной длины
        string filePath = "textfile.txt";
        string[] lines = {
            "Первая строка",
            "Вторая строка, подлиннее",
            "Третья",
            "Четвертая строка - самая длинная из всех",
            "Пятая"
        };
        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Файл создан.\n");

        // a) Вывод всего файла на экран
        Console.WriteLine("a) Содержимое файла:");
        string[] fileLines = File.ReadAllLines(filePath);
        foreach (string line in fileLines)
            Console.WriteLine(line);
        Console.WriteLine();

        // b) Подсчет количества строк
        Console.WriteLine($"b) Количество строк: {fileLines.Length}");

        // c) Подсчет символов в каждой строке
        Console.WriteLine("c) Количество символов в строках:");
        for (int i = 0; i < fileLines.Length; i++)
            Console.WriteLine($"Строка {i + 1}: {fileLines[i].Length} символов");
        Console.WriteLine();

        // d) Удаление последней строки и запись в новый файл
        string newFilePath = "newfile.txt";
        File.WriteAllLines(newFilePath, fileLines.Take(fileLines.Length - 1));
        Console.WriteLine($"d) Последняя строка удалена. Результат в файле {newFilePath}");

        // e) Вывод строк с s1 по s2 (пример для строк 2-4)
        int s1 = 2, s2 = 4;
        Console.WriteLine($"\ne) Строки с {s1} по {s2}:");
        for (int i = s1 - 1; i < s2 && i < fileLines.Length; i++)
            Console.WriteLine(fileLines[i]);
        Console.WriteLine();

        // f) Нахождение самой длинной строки
        string longestLine = fileLines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"f) Самая длинная строка ({longestLine.Length} символов):\n{longestLine}");
        Console.WriteLine();

        // g) Вывод строк, начинающихся с заданной буквы (например 'П')
        char startChar = 'П';
        Console.WriteLine($"g) Строки, начинающиеся на '{startChar}':");
        foreach (string line in fileLines.Where(line => line.StartsWith(startChar.ToString())))
            Console.WriteLine(line);
        Console.WriteLine();

        // h) Запись строк в обратном порядке в другой файл
        string reversedFilePath = "reversed.txt";
        File.WriteAllLines(reversedFilePath, fileLines.Reverse());
        Console.WriteLine($"h) Строки записаны в обратном порядке в файл {reversedFilePath}");

        // Вывод содержимого файла с обратными строками
        Console.WriteLine("\nСодержимое файла с обратным порядком строк:");
        foreach (string line in File.ReadAllLines(reversedFilePath))
            Console.WriteLine(line);
    }
}