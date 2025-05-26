using System;

class Program
{
    static void Main()
    {
        // Ввод трёхзначного числа
        Console.Write("Введите трёхзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка на трёхзначность
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка: число должно быть трёхзначным.");
            return;
        }

        // Извлечение цифр
        int secondDigit = (number / 10) % 10; // Вторая цифра
        int lastDigit = number % 10;          // Последняя цифра

        // Вычисление произведения
        int product = secondDigit * lastDigit;

        // Вывод результата
        Console.WriteLine($"Произведение второй и последней цифры: {product}");
    }
}
