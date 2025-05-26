using System;

class Program
{
    static void Main()
    {
        // Ввод предложения с клавиатуры
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        // Разделение предложения на слова
        string[] words = input.Split(' ');

        // Проверка на наличие достаточного количества слов
        if (words.Length < 3)
        {
            Console.WriteLine("Предложение должно содержать как минимум три слова.");
            return;
        }

        // Поменять местами первое и последнее слова
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        Console.WriteLine("\nПервое и последнее слова поменяны местами:");
        Console.WriteLine(string.Join(" ", words));

        // Склеить второе и третье слова
        string mergedWords = words[1] + words[2];
        Console.WriteLine("\nСклеенное второе и третье слова:");
        Console.WriteLine(mergedWords);

        // Третье слово в обратном порядке
        char[] reversed = words[2].ToCharArray();
        Array.Reverse(reversed);
        Console.WriteLine("\nТретье слово в обратном порядке:");
        Console.WriteLine(new string(reversed));

        // Вырезать первые две буквы в первом слове
        string firstWordModified = words[0].Length > 2 ? words[0].Substring(2) : "";
        Console.WriteLine("\nПервое слово без первых двух букв:");
        Console.WriteLine(firstWordModified);
    }
}
