using System;

namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            else if (SideA == SideB || SideB == SideC || SideA == SideC)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }
}
