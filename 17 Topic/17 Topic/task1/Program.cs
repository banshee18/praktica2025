using System;
using System.Drawing;
using GeometryLibrary;

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle(5, 5, 5);
        Console.WriteLine($"Треугольник ({triangle.GetTriangleType()}):");
        Console.WriteLine($"Периметр: {triangle.GetPerimeter()}");
        Console.WriteLine($"Площадь: {triangle.GetArea()}");

        Rectangle rectangle = new Rectangle(4, 6);
        Console.WriteLine("\nПрямоугольник:");
        Console.WriteLine($"Периметр: {rectangle.GetPerimeter()}");
        Console.WriteLine($"Площадь: {rectangle.GetArea()}");
    }
}
