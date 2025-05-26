using System;

class Program
{
    static void Main()
    {
        byte x = 200;
        byte y = 200;

        try
        {
            // Блок без проверки переполнения (unchecked)
            byte result = unchecked((byte)(x + y));
            Console.WriteLine("1: {0}", result);

            // Блок с проверкой переполнения (checked)
            result = checked((byte)(x + y));
            Console.WriteLine("2: {0}", result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}
