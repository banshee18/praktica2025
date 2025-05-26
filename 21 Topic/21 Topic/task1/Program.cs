using System;

public sealed class Singleton
{
    private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());

    private Singleton() { }

    public static Singleton Instance
    {
        get { return _instance.Value; }
    }

    public void ShowMessage()
    {
        Console.WriteLine("Экземпляр Singleton успешно создан!");
    }
}

class Program
{
    static void Main()
    {
        // Проверка работы Singleton
        Singleton.Instance.ShowMessage();
    }
}
