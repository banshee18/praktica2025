using System;

/// <summary>
/// Делегат для вычисления геометрических характеристик фигур по радиусу
/// </summary>
/// <param name="r">Радиус фигуры</param>
/// <returns>Результат вычисления (длина, площадь или объем)</returns>
delegate double CalcFigure(double r);

/// <summary>
/// Класс Program содержит методы для вычисления геометрических характеристик окружности и шара
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет длину окружности по заданному радиусу
    /// </summary>
    /// <param name="r">Радиус окружности</param>
    /// <returns>Длина окружности по формуле D = 2πr</returns>
    static double Get_Length(double r)
    {
        return 2 * Math.PI * r;
    }

    /// <summary>
    /// Вычисляет площадь круга по заданному радиусу
    /// </summary>
    /// <param name="r">Радиус круга</param>
    /// <returns>Площадь круга по формуле S = πr²</returns>
    static double Get_Area(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }

    /// <summary>
    /// Вычисляет объем шара по заданному радиусу
    /// </summary>
    /// <param name="r">Радиус шара</param>
    /// <returns>Объем шара по формуле V = (4/3)πr³</returns>
    static double Get_Volume(double r)
    {
        return (4.0 / 3) * Math.PI * Math.Pow(r, 3);
    }

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <remarks>
    /// Программа запрашивает у пользователя радиус, затем вычисляет и выводит:
    /// 1. Длину окружности
    /// 2. Площадь круга
    /// 3. Объем шара
    /// Все результаты выводятся с точностью до 4 знаков после запятой.
    /// Для вычислений используется делегат CalcFigure.
    /// </remarks>
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