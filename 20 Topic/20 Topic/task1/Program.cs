using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четырехзначное число:");
        int number = int.Parse(Console.ReadLine());

        // Вариант 1: Создание Task через конструктор
        Task<int> task1 = new Task<int>(() => SwapDigits(number));
        task1.Start();
        Console.WriteLine($"Результат (вариант 1): {task1.Result}");

        // Вариант 2: Создание Task через Task.Factory.StartNew
        Task<int> task2 = Task.Factory.StartNew(() => SwapDigits(number));
        Console.WriteLine($"Результат (вариант 2): {task2.Result}");

        // Вариант 3: Создание Task через Task.Run
        Task<int> task3 = Task.Run(() => SwapDigits(number));
        Console.WriteLine($"Результат (вариант 3): {task3.Result}");
    }

    static int SwapDigits(int num)
    {
        if (num < 1000 || num > 9999)
            throw new ArgumentException("Число должно быть четырехзначным");

        int firstTwo = num / 100;    // Первые две цифры
        int lastTwo = num % 100;     // Последние две цифры

        return lastTwo * 100 + firstTwo; // Перестановка
    }
}