using System;
using System.Linq;

class Program
{
    static int GetLetterValue(char c)
    {
        string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        c = char.ToUpper(c);

        int index = alphabet.IndexOf(c);
        return index >= 0 ? index + 1 : 0;
    }

    static int ReduceToSingleDigit(int number)
    {
        while (number >= 10)
        {
            number = number.ToString().Sum(c => c - '0');
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Введите Фамилию, Имя и Отчество:");
        string fullName = Console.ReadLine();

        string[] parts = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 3)
        {
            Console.WriteLine("Введите полное имя, включая фамилию, имя и отчество.");
            return;
        }

        Console.WriteLine("\nИсходные данные: " + fullName);
        Console.WriteLine("\nПорядковые номера букв:");

        int[] sums = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            Console.Write($"{parts[i]}: ");
            int sum = parts[i].Where(char.IsLetter).Sum(c => GetLetterValue(c));
            sums[i] = sum;
            Console.WriteLine(string.Join(" + ", parts[i].Where(char.IsLetter).Select(c => GetLetterValue(c))) + $" = {sum}");
        }

        int totalSum = sums.Sum();
        int reducedSum = ReduceToSingleDigit(totalSum);

        Console.WriteLine("\nИтоговая сумма: " + totalSum);
        Console.WriteLine("Сокращение до однозначного числа:");
        Console.WriteLine(string.Join(" + ", totalSum.ToString().Select(c => c - '0')) + $" = {reducedSum}");
        Console.WriteLine($"\nКод личности: {reducedSum}");
    }
}