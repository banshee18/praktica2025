using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] values = { 47, 16, 34, 87, 23 };
        ConcurrentBag<long> sums = new ConcurrentBag<long>();
        ConcurrentBag<long> products = new ConcurrentBag<long>();
        CancellationTokenSource cts = new CancellationTokenSource();

        Parallel.ForEach(values, new ParallelOptions { CancellationToken = cts.Token }, (n) =>
        {
            long sum = 0;
            long product = 1;

            for (int i = 0; i <= n; i++)
            {
                sum += i;
                if (i > 0)
                {
                    product *= i; // Избегаем умножения на 0
                }
            }

            if (sum > 1000)
            {
                Console.WriteLine($"Сумма для N={n} превышает 1000. Прерывание.");
                cts.Cancel(); // Прерываем все задачи
                return; // Возврат из текущей задачи
            }

            sums.Add(sum);
            products.Add(product);
        });

        // Вывод результатов
        Console.WriteLine("Суммы:");
        foreach (var s in sums)
        {
            Console.WriteLine($"Сумма для N={s}: {s}");
        }

        Console.WriteLine("\nПроизведения:");
        foreach (var p in products)
        {
            Console.WriteLine($"Произведение для N={p}: {p}");
        }
    }
}