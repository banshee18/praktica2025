using System;

class Program
{
    static void Main()
    {
        // Ввод числа
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка на четырехзначность
        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Ошибка: число должно быть четырехзначным.");
            return;
        }

        // Разделение числа на цифры
        int firstTwoDigits = number / 100; // Первые две цифры
        int lastTwoDigits = number % 100; // Последние две цифры

        // Перестановка цифр
        int rearrangedNumber = lastTwoDigits * 100 + firstTwoDigits;

        // Вывод результата
        Console.WriteLine($"Число после перестановки: {rearrangedNumber}");
    }
}