using System;
using System.Threading;

class Program
{
    static int[] numbers; // Массив чисел
    static int threadsCount; // Количество потоков
    static int[] partialSums; // Массив для частичных сумм

    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество чисел:");
        int n = int.Parse(Console.ReadLine());
        numbers = new int[n];

        Console.WriteLine("Введите числа через пробел:");
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        Console.WriteLine("Введите количество потоков:");
        threadsCount = int.Parse(Console.ReadLine());
        partialSums = new int[threadsCount];

        Thread[] threads = new Thread[threadsCount];

        // Создаем и запускаем потоки
        for (int i = 0; i < threadsCount; i++)
        {
            int threadIndex = i; // Важно создать копию для каждого потока
            threads[i] = new Thread(() => CalculatePartialSum(threadIndex));
            threads[i].Start();
        }

        // Ожидаем завершения всех потоков
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        // Вычисляем общую сумму
        int totalSum = 0;
        foreach (int sum in partialSums)
        {
            totalSum += sum;
        }

        Console.WriteLine($"Сумма четных чисел: {totalSum}");
    }

    static void CalculatePartialSum(int threadIndex)
    {
        int start = threadIndex * (numbers.Length / threadsCount);
        int end = (threadIndex == threadsCount - 1) ? numbers.Length : (threadIndex + 1) * (numbers.Length / threadsCount);

        int sum = 0;
        for (int i = start; i < end; i++)
        {
            if (numbers[i] % 2 == 0) // Проверяем четность
            {
                sum += numbers[i];
            }
        }

        partialSums[threadIndex] = sum;
        Console.WriteLine($"Поток {threadIndex}: частичная сумма = {sum}");
    }
}