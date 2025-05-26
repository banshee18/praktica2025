using System;
using System.Collections.Generic;

// Базовый класс Автомобиль
abstract class Car
{
    public string Name { get; set; }

    public Car(string name)
    {
        Name = name;
    }

    // Виртуальный метод расчета расхода топлива
    public abstract double CalculateFuelConsumption();

    // Виртуальный метод вывода информации
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Автомобиль: {Name}");
    }
}

// Класс Грузовой автомобиль
class Truck : Car
{
    public double LoadCapacity { get; set; } // грузоподъемность в тоннах

    public Truck(string name, double loadCapacity) : base(name)
    {
        LoadCapacity = loadCapacity;
    }

    public override double CalculateFuelConsumption()
    {
        return Math.Sqrt(LoadCapacity) * 100;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Тип: Грузовой\nГрузоподъемность: {LoadCapacity} т\nРасход топлива: {CalculateFuelConsumption():F2} л/100км");
        Console.WriteLine("----------------------");
    }
}

// Класс Легковой автомобиль
class PassengerCar : Car
{
    public double EngineVolume { get; set; } // объем двигателя в см^3

    public PassengerCar(string name, double engineVolume) : base(name)
    {
        EngineVolume = engineVolume;
    }

    public override double CalculateFuelConsumption()
    {
        return 2.5 * EngineVolume;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Тип: Легковой\nОбъем двигателя: {EngineVolume} см^3\nРасход топлива: {CalculateFuelConsumption():F2} л/100км");
        Console.WriteLine("----------------------");
    }
}

class Program
{
    static void Main()
    {
        // Создаем полиморфный контейнер (массив/список базового класса)
        List<Car> cars = new List<Car>
        {
            new Truck("Грузовик-1", 10),
            new PassengerCar("Седан-1", 2.0),
            new Truck("Грузовик-2", 15),
            new PassengerCar("Хэтчбек-1", 1.6),
            new Truck("Грузовик-3", 20),
            new PassengerCar("Внедорожник-1", 3.5)
        };

        // Выводим протокол испытаний
        Console.WriteLine("=== ПРОТОКОЛ РАСЧЕТА РАСХОДА ТОПЛИВА ===");
        Console.WriteLine($"Всего автомобилей: {cars.Count}\n");

        foreach (var car in cars)
        {
            car.PrintInfo();
        }

        // Дополнительная статистика
        double totalConsumption = 0;
        foreach (var car in cars)
        {
            totalConsumption += car.CalculateFuelConsumption();
        }
        Console.WriteLine($"Средний расход всех автомобилей: {totalConsumption / cars.Count:F2} л/100км");
    }
}