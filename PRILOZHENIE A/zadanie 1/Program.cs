using System;

class Program
{
    static void Main()
    {
        // Приветствие пользователя
        Console.WriteLine("Введите два целых числа:");

        // Запрос первого числа
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Запрос второго числа
        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Вычисления
        int sum = number1 + number2;
        int difference = number1 - number2;
        int product = number1 * number2;

        // Вывод результатов
        Console.WriteLine("\nРезультаты:");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Разность: {difference}");
        Console.WriteLine($"Произведение: {product}");

        // Завершение диалога
        Console.WriteLine("\nСпасибо за использование программы!");
    }
}