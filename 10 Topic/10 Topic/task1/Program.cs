using System;

// Базовый класс Квартира
class Apartment
{
    // Закрытые поля
    private string title;
    private double pricePerSquare;
    private double area;

    // Конструктор с параметрами
    public Apartment(string title, double pricePerSquare, double area)
    {
        this.title = title;
        this.pricePerSquare = pricePerSquare;
        this.area = area;
    }

    // Методы доступа к закрытым полям
    public string GetTitle() => title;
    public double GetPricePerSquare() => pricePerSquare;
    public double GetArea() => area;

    // Метод для вывода информации
    public virtual void Display()
    {
        Console.WriteLine($"Квартира: {title}");
        Console.WriteLine($"Стоимость за м^2: {pricePerSquare} руб.");
        Console.WriteLine($"Площадь: {area} м^2");
    }

    // Метод расчета стоимости квартиры
    public virtual double CalculateCost()
    {
        return pricePerSquare * area;
    }
}

// Производный класс Квартира в центре
class CentralApartment : Apartment
{
    // Дополнительное закрытое поле
    private string districtName;

    // Конструктор с параметрами
    public CentralApartment(string title, double pricePerSquare, double area, string districtName)
        : base(title, pricePerSquare, area)
    {
        this.districtName = districtName;
    }

    // Метод доступа к новому полю
    public string GetDistrictName() => districtName;

    // Переопределенный метод вывода информации
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Район: {districtName}");
    }

    // Переопределенный метод расчета стоимости с надбавкой 1%
    public override double CalculateCost()
    {
        double baseCost = base.CalculateCost();
        return baseCost * 1.01; // Увеличиваем стоимость на 1%
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Тестирование класса Apartment:");
        Console.WriteLine("------------------------------");

        // Создаем объект базового класса
        Apartment apt1 = new Apartment("Уютная", 100000, 50);

        // Проверяем методы базового класса
        Console.WriteLine($"Название: {apt1.GetTitle()}");
        Console.WriteLine($"Цена за м^2: {apt1.GetPricePerSquare()}");
        Console.WriteLine($"Площадь: {apt1.GetArea()} м^2");
        apt1.Display();
        Console.WriteLine($"Стоимость квартиры: {apt1.CalculateCost():F2} руб.");
        Console.WriteLine();

        Console.WriteLine("Тестирование класса CentralApartment:");
        Console.WriteLine("-------------------------------------");

        // Создаем объект производного класса
        CentralApartment cap1 = new CentralApartment("Престижная", 150000, 75, "Центральный");

        // Проверяем методы производного класса
        Console.WriteLine($"Название: {cap1.GetTitle()}");
        Console.WriteLine($"Цена за м^2: {cap1.GetPricePerSquare()}");
        Console.WriteLine($"Площадь: {cap1.GetArea()} м^2");
        Console.WriteLine($"Район: {cap1.GetDistrictName()}");
        cap1.Display();
        Console.WriteLine($"Стоимость квартиры с надбавкой: {cap1.CalculateCost():F2} руб.");
        Console.WriteLine();

        // Проверяем разницу в стоимости
        double baseCost = cap1.GetPricePerSquare() * cap1.GetArea();
        Console.WriteLine($"Стоимость без надбавки: {baseCost:F2} руб.");
        Console.WriteLine($"Надбавка за расположение: {cap1.CalculateCost() - baseCost:F2} руб.");
    }
}