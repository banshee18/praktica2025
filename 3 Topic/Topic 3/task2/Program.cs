using System;

class Program
{
    // Процедура правого циклического сдвига
    static void ShiftRight3(ref double A, ref double B, ref double C)
    {
        double temp = C;
        C = B;
        B = A;
        A = temp;
    }

    static void Main()
    {
        // Первый набор чисел
        double A1 = 1.1, B1 = 2.2, C1 = 3.3;
        Console.WriteLine($"Первый набор до сдвига: A1 = {A1}, B1 = {B1}, C1 = {C1}");
        ShiftRight3(ref A1, ref B1, ref C1);
        Console.WriteLine($"Первый набор после сдвига: A1 = {A1}, B1 = {B1}, C1 = {C1}");

        // Второй набор чисел
        double A2 = 4.4, B2 = 5.5, C2 = 6.6;
        Console.WriteLine($"\nВторой набор до сдвига: A2 = {A2}, B2 = {B2}, C2 = {C2}");
        ShiftRight3(ref A2, ref B2, ref C2);
        Console.WriteLine($"Второй набор после сдвига: A2 = {A2}, B2 = {B2}, C2 = {C2}");
    }
}
