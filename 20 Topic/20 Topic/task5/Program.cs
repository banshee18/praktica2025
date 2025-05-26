using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 47, 16, 34, 87, 23 };
        Dictionary<int, (long sum, long product)> results = new Dictionary<int, (long, long)>();

        object lockObj = new object(); // Для безопасного обновления коллекции
        bool shouldStop = false; // Флаг для прерывания

        Parallel.ForEach(numbers, (N, state) =>
        {
            long sum = 0;
            long product = 1;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
                product *= i;

                // Условие прерывания (например, если сумма превышает 10^6)
                if (sum > 1_000_000)
                {
                    Console.WriteLine($"Прерывание вычисления для {N}, сумма превысила 10^6.");
                    shouldStop = true;
                    state.Stop(); // Останавливает выполнение дальнейших итераций
                    break;
                }
            }

            // Безопасное добавление результатов в коллекцию
            lock (lockObj)
            {
                if (!shouldStop)
                {
                    results[N] = (sum, product);
                }
            }
        });

        // Вывод результатов
        Console.WriteLine("\nРезультаты вычислений:");
        foreach (var kvp in results)
        {
            Console.WriteLine($"N = {kvp.Key}: Сумма = {kvp.Value.sum}, Произведение = {kvp.Value.product}");
        }
    }
}