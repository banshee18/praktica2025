using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трёхзначное число:");
        int number = int.Parse(Console.ReadLine());

        // Первая задача - вычисление произведения
        Task<int> firstTask = Task.Run(() => CalculateProduct(number));

        // Вторая задача - продолжение, вывод результата
        Task continuationTask = firstTask.ContinueWith(prevTask =>
        {
            Console.WriteLine($"Произведение второй и последней цифр: {prevTask.Result}");
        });

        // Ожидаем завершения второй задачи
        continuationTask.Wait();
    }

    static int CalculateProduct(int number)
    {
        if (number < 100 || number > 999)
        {
            throw new ArgumentException("Число должно быть трёхзначным");
        }

        int secondDigit = (number / 10) % 10;  // Вторая цифра
        int lastDigit = number % 10;          // Последняя цифра

        return secondDigit * lastDigit;
    }
}