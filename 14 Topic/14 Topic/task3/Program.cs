using System;
using System.Threading;

class Program
{
    static readonly object lockObject = new object();
    static int A, N;

    static void Main()
    {
        Console.WriteLine("Введите значение A:");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        N = int.Parse(Console.ReadLine());

        // Создаем потоки для суммы (могут выполняться одновременно)
        Thread sumThread1 = new Thread(CalculateSum);
        Thread sumThread2 = new Thread(CalculateSum);

        // Создаем потоки для произведения (будет выполняться только один одновременно)
        Thread productThread1 = new Thread(CalculateProduct);
        Thread productThread2 = new Thread(CalculateProduct);

        // Запускаем потоки
        sumThread1.Start("Сумма поток 1");
        sumThread2.Start("Сумма поток 2");
        productThread1.Start("Произведение поток 1");
        productThread2.Start("Произведение поток 2");

        // Ожидаем завершения всех потоков
        sumThread1.Join();
        sumThread2.Join();
        productThread1.Join();
        productThread2.Join();

        Console.WriteLine("Все потоки завершили работу.");
    }

    // Метод для вычисления суммы (может выполняться несколькими потоками одновременно)
    static void CalculateSum(object threadName)
    {
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += A * i;
            Thread.Sleep(50); // Имитация работы
        }
        Console.WriteLine($"{threadName}: A*1 + A*2 + ... + A*{N} = {sum}");
    }

    // Метод для вычисления произведения (выполняется только одним потоком в момент времени)
    static void CalculateProduct(object threadName)
    {
        lock (lockObject) // Блокировка для синхронизации
        {
            int product = 1;
            for (int i = 1; i <= N; i++)
            {
                product *= A * i;
                Thread.Sleep(50); // Имитация работы
            }
            Console.WriteLine($"{threadName}: A*1 * A*2 * ... * A*{N} = {product}");
        }
    }
}