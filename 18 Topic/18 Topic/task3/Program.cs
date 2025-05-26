using System;
using System.Collections.Generic;

// Базовый абстрактный класс-прототип
public abstract class HikePrototype<T> where T : class
{
    protected List<T> participants = new List<T>();
    protected Dictionary<string, T> participantDictionary = new Dictionary<string, T>();

    // Обобщенный метод добавления
    public void AddParticipant(string id, T participant)
    {
        if (participant == null)
            throw new ArgumentNullException(nameof(participant));

        participants.Add(participant);
        participantDictionary.Add(id, participant);
    }

    // Обобщенный метод удаления
    public bool RemoveParticipant(string id)
    {
        if (participantDictionary.TryGetValue(id, out T participant))
        {
            participantDictionary.Remove(id);
            participants.Remove(participant);
            return true;
        }
        return false;
    }

    // Абстрактный метод клонирования
    public abstract HikePrototype<T> Clone();

    // Метод для вывода информации
    public void PrintParticipants()
    {
        Console.WriteLine("\nУчастники похода:");
        foreach (var p in participants)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine("\nСловарь участников:");
        foreach (var kvp in participantDictionary)
        {
            Console.WriteLine($"ID: {kvp.Key} -> {kvp.Value}");
        }
    }
}

// Конкретная реализация для походов
public class HikeOrganization<T> : HikePrototype<T> where T : class
{
    public string? HikeName { get; set; } // Обнуляемое свойство
    public DateTime? StartDate { get; set; } // Обнуляемое свойство

    public override HikePrototype<T> Clone()
    {
        var clone = new HikeOrganization<T>
        {
            HikeName = this.HikeName,
            StartDate = this.StartDate
        };

        // Глубокая копия коллекций
        clone.participants = new List<T>(this.participants);
        clone.participantDictionary = new Dictionary<string, T>(this.participantDictionary);

        return clone;
    }

    public void PrintHikeInfo()
    {
        Console.WriteLine($"\nИнформация о походе: {HikeName ?? "Название не указано"}");
        Console.WriteLine($"Дата начала: {StartDate?.ToString() ?? "Не назначена"}");
    }
}

// Класс участника похода
public class Hiker
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Specialization { get; set; }

    public override string ToString() =>
        $"{Name} (Возраст: {Age?.ToString() ?? "не указан"}, Специализация: {Specialization ?? "нет"})";
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Организация похода ===");

        // 1. Создаем организацию похода
        var hike = new HikeOrganization<Hiker>
        {
            HikeName = "Восхождение на Эльбрус",
            StartDate = new DateTime(2023, 7, 15)
        };

        // 2. Добавляем участников (демонстрация обнуляемых типов)
        hike.AddParticipant("001", new Hiker
        {
            Name = "Иван Петров",
            Age = 32,
            Specialization = "Проводник"
        });

        hike.AddParticipant("002", new Hiker
        {
            Name = "Мария Сидорова",
            Age = null, // Обнуляемое поле
            Specialization = "Повар"
        });

        hike.AddParticipant("003", new Hiker
        {
            Name = "Алексей Иванов",
            Age = 28,
            Specialization = null // Обнуляемое поле
        });

        // 3. Выводим информацию
        hike.PrintHikeInfo();
        hike.PrintParticipants();

        // 4. Демонстрация удаления участника
        Console.WriteLine("\nУдаляем участника с ID 002");
        bool removed = hike.RemoveParticipant("002");
        Console.WriteLine($"Удаление {(removed ? "успешно" : "не удалось")}");
        hike.PrintParticipants();

        // 5. Демонстрация клонирования
        Console.WriteLine("\nКлонируем организацию похода...");
        var clonedHike = (HikeOrganization<Hiker>)hike.Clone();
        clonedHike.HikeName = "Клон похода на Эльбрус";

        Console.WriteLine("\nОригинальный поход:");
        hike.PrintHikeInfo();

        Console.WriteLine("\nКлонированный поход:");
        clonedHike.PrintHikeInfo();
        clonedHike.PrintParticipants();

        // 6. Демонстрация работы с List<T> и Dictionary<Key,Value>
        Console.WriteLine("\n=== Работа с коллекциями ===");

        // Использование List<T>
        List<Hiker> hikersList = new List<Hiker>(hike.GetParticipants());
        Console.WriteLine("\nСписок участников (List<Hiker>):");
        foreach (var hiker in hikersList)
        {
            Console.WriteLine(hiker);
        }

        // Использование Dictionary<Key,Value>
        Dictionary<string, Hiker> hikersDict = new Dictionary<string, Hiker>
        {
            { "004", new Hiker { Name = "Елена Ветрова", Age = 25, Specialization = "Медик" } },
            { "005", new Hiker { Name = "Дмитрий Лесов", Age = null, Specialization = "Фотограф" } }
        };

        Console.WriteLine("\nСловарь участников (Dictionary<string,Hiker>):");
        foreach (var kvp in hikersDict)
        {
            Console.WriteLine($"ID: {kvp.Key} -> {kvp.Value}");
        }
    }
}

// Метод расширения для доступа к участникам
public static class HikeExtensions
{
    public static List<T> GetParticipants<T>(this HikePrototype<T> hike) where T : class
    {
        return hike.GetType()
            .GetField("participants", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            ?.GetValue(hike) as List<T> ?? new List<T>();
    }
}