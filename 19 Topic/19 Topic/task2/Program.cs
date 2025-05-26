using System;

/// <summary>
/// Класс Program содержит методы для выполнения циклического сдвига значений
/// </summary>
class Program
{
    /// <summary>
    /// Выполняет правый циклический сдвиг трех значений
    /// </summary>
    /// <param name="A">Первое значение (ref - передача по ссылке)</param>
    /// <param name="B">Второе значение (ref - передача по ссылке)</param>
    /// <param name="C">Третье значение (ref - передача по ссылке)</param>
    /// <remarks>
    /// Процедура модифицирует переданные параметры, выполняя сдвиг:
    /// Значение C перемещается в A,
    /// Значение B перемещается в C,
    /// Значение A перемещается в B
    /// </remarks>
    /// <example>
    /// Пример использования:
    /// <code>
    /// double x = 1, y = 2, z = 3;
    /// ShiftRight3(ref x, ref y, ref z);
    /// // После вызова: x=3, y=1, z=2
    /// </code>
    /// </example>
    static void ShiftRight3(ref double A, ref double B, ref double C)
    {
        double temp = C;
        C = B;
        B = A;
        A = temp;
    }

    /// <summary>
    /// Главный метод программы, демонстрирующий работу процедуры ShiftRight3
    /// </summary>
    /// <remarks>
    /// Метод демонстрирует выполнение циклического сдвига для двух наборов чисел
    /// и выводит результаты до и после сдвига
    /// </remarks>
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