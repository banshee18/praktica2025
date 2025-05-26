using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        const double A = -5.0;
        const double B = 16.0;
        const double step = 0.1;
        int points = (int)((B - A) / step) + 1;
        double[] results = new double[points];

        Parallel.For(0, points, i =>
        {
            double x = A + i * step;
            results[i] = Math.Sin(x * x);
        });

        // Упорядоченный вывод
        Console.WriteLine("{0,8} | {1,20}", "x", "sin(x^2)");
        Console.WriteLine(new string('-', 32));
        for (int i = 0; i < points; i++)
        {
            double x = A + i * step;
            Console.WriteLine($"{x,8:F2} | {results[i],20:F15}");
        }
    }
}