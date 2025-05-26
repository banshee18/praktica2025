using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер матрицы (N<10):");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите диапазон [a, b]:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        var random = new Random();
        var matrix = Enumerable.Range(0, N).Select(_ => Enumerable.Range(0, N).Select(_ => random.Next(a, b + 1)).ToArray()).ToArray();
        Console.WriteLine("Исходная матрица:\n" + string.Join("\n", matrix.Select(row => string.Join("\t", row))));

        var avg = matrix.SelectMany(row => row).Where(x => x < M).DefaultIfEmpty().Average();
        Console.WriteLine($"\nСреднее арифметическое чисел, меньших {M}: {avg}");

        var colSums = Enumerable.Range(0, N).Select(j => matrix.Sum(row => row[j] > 0 ? row[j] : 0));
        Console.WriteLine("\nСумма положительных элементов каждого столбца:\n" + string.Join("\n", colSums.Select((sum, j) => $"Столбец {j + 1}: {sum}")));
    }
}
