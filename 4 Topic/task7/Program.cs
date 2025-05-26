using System;

class Program
{
    // Метод SortDec3 для упорядочивания трёх чисел по убыванию
    static void SortDec3(ref double A, ref double B, ref double C)
    {
        if (double.IsNaN(A) || double.IsNaN(B) || double.IsNaN(C))
        {
            throw new ArgumentException("Один из параметров является некорректным (NaN).");
        }

        // Упорядочивание методом обмена
        if (A < B) Swap(ref A, ref B);
        if (A < C) Swap(ref A, ref C);
        if (B < C) Swap(ref B, ref C);
    }

    // Метод Swap для обмена значений
    static void Swap(ref double x, ref double y)
    {
        double temp = x;
        x = y;
        y = temp;
    }

    static void Main()
    {
        try
        {
            // Ввод первого набора чисел
            Console.WriteLine("Введите три числа для первого набора:");
            Console.Write("A1 = ");
            double A1 = double.Parse(Console.ReadLine());
            Console.Write("B1 = ");
            double B1 = double.Parse(Console.ReadLine());
            Console.Write("C1 = ");
            double C1 = double.Parse(Console.ReadLine());

            // Упорядочивание первого набора
            SortDec3(ref A1, ref B1, ref C1);
            Console.WriteLine($"Первый набор после сортировки: A1 = {A1}, B1 = {B1}, C1 = {C1}");

            // Ввод второго набора чисел
            Console.WriteLine("\nВведите три числа для второго набора:");
            Console.Write("A2 = ");
            double A2 = double.Parse(Console.ReadLine());
            Console.Write("B2 = ");
            double B2 = double.Parse(Console.ReadLine());
            Console.Write("C2 = ");
            double C2 = double.Parse(Console.ReadLine());

            // Упорядочивание второго набора
            SortDec3(ref A2, ref B2, ref C2);
            Console.WriteLine($"Второй набор после сортировки: A2 = {A2}, B2 = {B2}, C2 = {C2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Введено некорректное значение. Ожидалось вещественное число.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: Деление на ноль.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
