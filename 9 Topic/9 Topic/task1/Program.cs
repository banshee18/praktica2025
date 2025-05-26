using System;

interface Ix { void IxF0(double w); void IxF1(); }
interface Iy { void F0(double w); void F1(); }
interface Iz { void F0(double w); void F1(); }

class TestClass : Ix, Iy, Iz
{
    private double w;
    public TestClass(double w) => this.w = w;

    // Ix implementation
    public void IxF0(double w) => Console.WriteLine($"IxF0: w^2 = {w * w}");
    public void IxF1() => Console.WriteLine($"IxF1: √w = {Math.Sqrt(w)}");

    // Iy implementation (implicit)
    public void F0(double w) => Console.WriteLine($"Iy F0: w^2 = {w * w}");
    public void F1() => Console.WriteLine($"Iy F1: √w = {Math.Sqrt(w)}");

    // Iz implementation (explicit)
    void Iz.F0(double w) => Console.WriteLine($"Iz F0: w^2 + 5 = {w * w + 5}");
    void Iz.F1() => Console.WriteLine($"Iz F1: √w = {Math.Sqrt(w)}");
}

class Program
{
    static void Main()
    {
        var test = new TestClass(4.0);

        Console.WriteLine("Вызовы через интерфейс Ix:");
        test.IxF0(4); test.IxF1();

        Console.WriteLine("\nВызовы через интерфейс Iy:");
        test.F0(4); test.F1();

        Console.WriteLine("\nВызовы через интерфейс Iz:");
        ((Iz)test).F0(4); ((Iz)test).F1();

        Console.WriteLine("\nВызовы через интерфейсную ссылку:");
        Ix ix = test;
        ix.IxF0(4); ix.IxF1();
    }
}