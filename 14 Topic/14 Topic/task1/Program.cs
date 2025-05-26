using System;
using System.Threading;

class Program
{
    static AutoResetEvent event1 = new AutoResetEvent(true);
    static AutoResetEvent event2 = new AutoResetEvent(false);
    static AutoResetEvent event3 = new AutoResetEvent(false);

    static void Main(string[] args)
    {
        // Создаем потоки с разными приоритетами
        Thread thread1 = new Thread(PrintNumbers0To9)
        {
            Priority = ThreadPriority.Highest,
            Name = "Thread 1 (0-9)"
        };

        Thread thread2 = new Thread(PrintNumbers10To19)
        {
            Priority = ThreadPriority.Normal,
            Name = "Thread 2 (10-19)"
        };

        Thread thread3 = new Thread(PrintNumbers20To29)
        {
            Priority = ThreadPriority.Lowest,
            Name = "Thread 3 (20-29)"
        };

        // Запускаем потоки
        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Ждем завершения всех потоков
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("\nВсе потоки завершили работу.");
    }

    static void PrintNumbers0To9()
    {
        for (int i = 0; i < 10; i++)
        {
            event1.WaitOne();  // Ожидаем сигнал
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(100); // Имитация работы
            event2.Set();      // Разрешаем работу следующему потоку
        }
    }

    static void PrintNumbers10To19()
    {
        for (int i = 10; i < 20; i++)
        {
            event2.WaitOne();  // Ожидаем сигнал
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(100); // Имитация работы
            event3.Set();      // Разрешаем работу следующему потоку
        }
    }

    static void PrintNumbers20To29()
    {
        for (int i = 20; i < 30; i++)
        {
            event3.WaitOne();  // Ожидаем сигнал
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(100); // Имитация работы
            event1.Set();      // Возвращаем разрешение первому потоку
        }
    }
}