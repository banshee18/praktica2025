using System;

class Program
{
    static void Main()
    {
        // Константа: вес одного российского фунта в граммах
        const double gramsPerPound = 409.5;
        const double gramsInKilogram = 1000.0;

        // Ввод веса в фунтах
        Console.Write("Введите вес в фунтах: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        // Перевод веса в килограммы
        double kilograms = (pounds * gramsPerPound) / gramsInKilogram;

        // Вывод результата
        Console.WriteLine($"\n{pounds} фунт(а/ов) — это {kilograms:F2} кг.");
    }
}
