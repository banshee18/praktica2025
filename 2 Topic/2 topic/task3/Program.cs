using System;

class Fraction
{
    public int Numerator { get; set; }   // Числитель
    public int Denominator { get; set; } // Знаменатель

    // Конструктор
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю.");
        }

        Numerator = numerator;
        Denominator = denominator;
        Simplify(); // Упрощаем дробь при создании
    }

    // Метод упрощения дроби
    private void Simplify()
    {
        int gcd = GCD(Numerator, Denominator); // Находим НОД
        Numerator /= gcd;
        Denominator /= gcd;

        // Убедимся, что знаменатель всегда положительный
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    // Метод для нахождения НОД (наибольший общий делитель)
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    // Метод сложения
    public Fraction Add(Fraction other)
    {
        int numerator = Numerator * other.Denominator + other.Numerator * Denominator;
        int denominator = Denominator * other.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Метод вычитания
    public Fraction Subtract(Fraction other)
    {
        int numerator = Numerator * other.Denominator - other.Numerator * Denominator;
        int denominator = Denominator * other.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Метод умножения
    public Fraction Multiply(Fraction other)
    {
        int numerator = Numerator * other.Numerator;
        int denominator = Denominator * other.Denominator;
        return new Fraction(numerator, denominator);
    }

    // Метод деления
    public Fraction Divide(Fraction other)
    {
        if (other.Numerator == 0)
        {
            throw new DivideByZeroException("Невозможно делить на дробь с нулевым числителем.");
        }

        int numerator = Numerator * other.Denominator;
        int denominator = Denominator * other.Numerator;
        return new Fraction(numerator, denominator);
    }

    // Переопределение метода ToString для вывода дроби
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Создание двух дробей
            Fraction fraction1 = new Fraction(2, 3);
            Fraction fraction2 = new Fraction(3, 4);

            // Демонстрация операций
            Console.WriteLine($"Дробь 1: {fraction1}");
            Console.WriteLine($"Дробь 2: {fraction2}");

            Console.WriteLine($"\nСложение: {fraction1.Add(fraction2)}");
            Console.WriteLine($"Вычитание: {fraction1.Subtract(fraction2)}");
            Console.WriteLine($"Умножение: {fraction1.Multiply(fraction2)}");
            Console.WriteLine($"Деление: {fraction1.Divide(fraction2)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
