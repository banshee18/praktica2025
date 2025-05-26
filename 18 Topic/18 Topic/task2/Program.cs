using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа разделения символов и цифр из файла");
        Console.WriteLine("Введите путь к текстовому файлу:");
        string filePath = Console.ReadLine();

        try
        {
            ProcessFile(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static void ProcessFile(string filePath)
    {
        // Создаем две очереди: для символов и для цифр
        Queue<char> nonDigitsQueue = new Queue<char>();
        Queue<char> digitsQueue = new Queue<char>();

        // Читаем файл посимвольно
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                char c = (char)reader.Read();

                if (char.IsDigit(c))
                {
                    digitsQueue.Enqueue(c);
                }
                else
                {
                    nonDigitsQueue.Enqueue(c);
                }
            }
        }

        // Выводим сначала все символы, затем цифры
        Console.WriteLine("\nРезультат обработки файла:");

        // Выводим не-цифры
        while (nonDigitsQueue.Count > 0)
        {
            Console.Write(nonDigitsQueue.Dequeue());
        }

        // Выводим цифры
        while (digitsQueue.Count > 0)
        {
            Console.Write(digitsQueue.Dequeue());
        }

        Console.WriteLine();
    }
}