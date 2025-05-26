using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Генерация случайного массива
        Random random = new Random();
        int[] array = Enumerable.Range(0, 10).Select(_ => random.Next(-50, 50)).ToArray();
        Console.WriteLine("Сгенерированный массив:");
        Console.WriteLine(string.Join(" ", array));

        // Сортировка и бинарный поиск
        Array.Sort(array);
        Console.WriteLine("\nОтсортированный массив:");
        Console.WriteLine(string.Join(" ", array));

        Console.WriteLine("\nВведите число для поиска:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Array.BinarySearch(array, k) >= 0 ? $"Число {k} найдено." : $"Число {k} не найдено.");

        // Проверка и вывод результата
        bool hasEvenAfterOdd = false;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] % 2 != 0 && array[i] % 2 == 0)
            {
                hasEvenAfterOdd = true;
                break;
            }
        }

        var result = hasEvenAfterOdd
            ? array.Where(x => x > 0).Reverse()
            : array.Where(x => x < 0).Reverse();

        Console.WriteLine("\nРезультат:");
        Console.WriteLine(string.Join(" ", result));
    }
}
