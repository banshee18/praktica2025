using System;

class State // Базовый класс "Государство"
{
    public string Name { get; set; } // Название государства

    public State(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Государство: {Name}");
    }
}

class Republic : State // Производный класс "Республика"
{
    public string President { get; set; } // Имя президента

    public Republic(string name, string president) : base(name)
    {
        President = president;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Форма правления: Республика. Президент: {President}");
    }
}

class Monarchy : State // Производный класс "Монархия"
{
    public string Monarch { get; set; } // Имя монарха

    public Monarchy(string name, string monarch) : base(name)
    {
        Monarch = monarch;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Форма правления: Монархия. Монарх: {Monarch}");
    }
}

class Kingdom : Monarchy // Производный класс "Королевство" от "Монархия"
{
    public string RoyalFamily { get; set; } // Имя королевской династии

    public Kingdom(string name, string monarch, string royalFamily) : base(name, monarch)
    {
        RoyalFamily = royalFamily;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип монархии: Королевство. Королевская семья: {RoyalFamily}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объектов каждого класса
        State generalState = new State("Глобальное государство");
        Republic republic = new Republic("Республика Беларусь", "Александр Лукашенко");
        Monarchy monarchy = new Monarchy("Империя Япония", "Император Нарухито");
        Kingdom kingdom = new Kingdom("Великобритания", "Король Чарльз III", "Виндзоры");

        // Демонстрация работы
        generalState.DisplayInfo();
        Console.WriteLine();

        republic.DisplayInfo();
        Console.WriteLine();

        monarchy.DisplayInfo();
        Console.WriteLine();

        kingdom.DisplayInfo();
    }
}
