using System;
class A
{
    protected int a = 5, b = 10;
    public virtual int c => (int)Math.Pow(a, 2) + b;
    public A() { }
}
class B : A
{
    private int d = 15;
    public int c2 { get { int r = 0; for (int i = 1; i <= d; i++) r += a * b; return r; } }
    public B() { }
    public B(int a, int b, int d) { this.a = a; this.b = b; this.d = d; }
}
class P
{
    static void Main()
    {
        var a = new A();
        Console.WriteLine($"A.c={a.c}\n");
        var b1 = new B();
        Console.WriteLine($"B1.c={b1.c} B1.c2={b1.c2}\n");
        var b2 = new B(2, 3, 4);
        Console.WriteLine($"B2.c={b2.c} B2.c2={b2.c2}");
    }
}