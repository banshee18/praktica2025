using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        // Создаем два потока
        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        // Запускаем потоки
        thread1.Start("Поток 1");
        thread2.Start("Поток 2");

        // Ждем завершения обоих потоков
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершили работу.");
    }

    static void CalculateSum(object threadName)
    {
        // Засекаем время начала выполнения
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Вычисляем сумму чисел от 1 до 10
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            // Имитируем небольшую задержку для наглядности
            Thread.Sleep(100);
        }

        // Фиксируем время окончания
        stopwatch.Stop();

        // Выводим результат
        Console.WriteLine($"{threadName}: Сумма = {sum}, " +
                         $"Время выполнения = {stopwatch.ElapsedMilliseconds} мс");
    }
}