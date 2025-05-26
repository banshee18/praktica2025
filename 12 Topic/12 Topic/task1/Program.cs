using System;

// Объявляем тип делегата
delegate double CalcFigure(double r);

class Program
{
    // Статический метод для вычисления длины окружности
    static double Get_Length(double r)
    {
        return 2 * Math.PI * r;
    }

    // Статический метод для вычисления площади круга
    static double Get_Area(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    // Статический метод для вычисления объема шара
    static double Get_Volume(double r)
    {
        return (4.0 / 3) * Math.PI * Math.Pow(r, 3);
    }

    static void Main()
    {
        // Создаем экземпляр делегата
        CalcFigure CF;

        // Вводим радиус
        Console.Write("Введите радиус R: ");
        double r = double.Parse(Console.ReadLine());

        // Вычисляем длину окружности
        CF = Get_Length;
        double length = CF(r);
        Console.WriteLine($"Длина окружности (D = 2piR): {length:F4}");

        // Вычисляем площадь круга
        CF = Get_Area;
        double area = CF(r);
        Console.WriteLine($"Площадь круга (S = piR^2): {area:F4}");

        // Вычисляем объем шара
        CF = Get_Volume;
        double volume = CF(r);
        Console.WriteLine($"Объем шара (V = 4/3piR^3): {volume:F4}");
    }
}