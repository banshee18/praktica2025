using System;

class Program
{
    static void Main()
    {
        // Ввод значения угла alpha в радианах
        Console.Write("Введите угол α (в радианах): ");
        double alpha = Convert.ToDouble(Console.ReadLine());

        // Вычисление z1
        double numerator = Math.Sin(2 * alpha) + Math.Sin(5 * alpha) - Math.Sin(3 * alpha);
        double denominator = Math.Cos(alpha) + 1 - 2 * Math.Pow(Math.Sin(2 * alpha), 2);

        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: знаменатель равен нулю, вычисление z1 невозможно.");
        }
        else
        {
            double z1 = numerator / denominator;
            Console.WriteLine($"z1 = {z1:F4}");
        }

        // Вычисление z2
        double z2 = 2 * Math.Sin(alpha);
        Console.WriteLine($"z2 = {z2:F4}");
    }
}
