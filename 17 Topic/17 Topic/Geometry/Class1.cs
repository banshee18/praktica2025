using System;

namespace Geometry
{
    // Базовый абстрактный класс для всех фигур
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
    }

    // Класс треугольника
    public class Triangle : Shape
    {
        // Поля
        private double sideA;
        private double sideB;
        private double sideC;

        // Свойства с проверкой валидности
        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина стороны должна быть положительной");
                sideA = value;
            }
        }

        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина стороны должна быть положительной");
                sideB = value;
            }
        }

        public double SideC
        {
            get { return sideC; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина стороны должна быть положительной");
                sideC = value;
            }
        }

        // Конструкторы
        public Triangle() { }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            if (!IsValid())
                throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        // Метод проверки существования треугольника
        public bool IsValid()
        {
            return SideA + SideB > SideC &&
                   SideA + SideC > SideB &&
                   SideB + SideC > SideA;
        }

        // Переопределение метода вычисления периметра
        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        // Переопределение метода вычисления площади (формула Герона)
        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        // Метод определения типа треугольника
        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";

            if (SideA == SideB || SideA == SideC || SideB == SideC)
                return "Равнобедренный";

            return "Разносторонний";
        }
    }

    // Класс прямоугольника
    public class Rectangle : Shape
    {
        // Поля
        private double length;
        private double width;

        // Свойства с проверкой валидности
        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина должна быть положительной");
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть положительной");
                width = value;
            }
        }

        // Конструкторы
        public Rectangle() { }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Переопределение метода вычисления периметра
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        // Переопределение метода вычисления площади
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}