using System;

class Program
{
    static void Main()
    {
        // Размер массива
        int size = 10;

        // Создание случайного массива с числами до 20
        int[] numbers = GenerateRandomArray(size, 1, 20);
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbers);

        // Замена четных элементов нулями
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                numbers[i] = 0;
            }
        }

        // Вывод нового массива
        Console.WriteLine("\nМодифицированный массив:");
        PrintArray(numbers);
    }

    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
