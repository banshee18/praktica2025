using System;

class A
{
    // Поля
    public int a, b;

    // Конструктор для инициализации
    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    // Метод вычисления значения выражения 1/a^2 - 1/b^3
    public double CalculateExpression()
    {
        return (1 / Math.Pow(a, 2)) - (1 / Math.Pow(b, 3));
    }

    // Метод возведения суммы a + b в куб
    public double CubeOfSum()
    {
        return Math.Pow(a + b, 3);
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта класса A
        Console.Write("Введите значение a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        A obj = new A(a, b);

        // Демонстрация работы с элементами класса
        Console.WriteLine($"\nЗначения объекта: a = {obj.a}, b = {obj.b}");
        Console.WriteLine($"Значение выражения 1/a^2 - 1/b^3: {obj.CalculateExpression():F4}");
        Console.WriteLine($"Куб суммы a и b: {obj.CubeOfSum():F4}");
    }
}
