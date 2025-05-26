using System;

class Program
{
    static void Main()
    {
        byte n = 1;
        byte i;

        try
        {
            // Блок без проверки переполнения
            unchecked
            {
                for (i = 1; i < 10; i++)
                    n *= i; // Переполнение игнорируется
                Console.WriteLine("1: {0}", n); // Выводит результат с обёрткой
            }

            // Блок с проверкой переполнения
            checked
            {
                n = 1;
                for (i = 1; i < 10; i++)
                    n *= i; // Здесь произойдёт переполнение, и выбросится исключение
                Console.WriteLine("2: {0}", n); // Этот код не выполнится
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}
