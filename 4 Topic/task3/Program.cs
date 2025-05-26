using System;

class Program
{
    static void genException()
    {
        Console.WriteLine("Введите значения для 'a' и 'b':");

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        int f = 1;

        try // Внешний блок try
        {
            for (double i = a; i <= b; ++i)
            {
                try // Внутренний блок try
                {
                    f = checked((int)(f * i));

                    // Проверка условия f - 1 < 0.000001
                    if (Math.Abs(f - 1) < 0.000001)
                    {
                        throw new DivideByZeroException("f - 1 слишком близко к нулю, деление невозможно!");
                    }

                    // Вывод корректного результата
                    Console.WriteLine($"Результат y({i}) = {100 / (f - 1):f6}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Результат y({i}) = Ошибка: {ex.Message}");
                }
            }
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("ERROR");
            throw; // Повторная генерация исключения
        }
    }

    static void Main()
    {
        try
        {
            genException();
        }
        catch
        {
            Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
        }
    }
}
