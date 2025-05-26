using System;

// Класс, генерирующий события
class EventPublisher
{
    // Делегат для события
    public delegate void NotifyHandler(string message);

    // Событие
    public event NotifyHandler NotifyEvent;

    // Метод для генерации события
    public void RaiseEvent(string message)
    {
        Console.WriteLine($"\nГенерация события: {message}");
        NotifyEvent?.Invoke(message);
    }
}

// Первый класс-наблюдатель
class FirstObserver
{
    public void ReactToEvent(string message)
    {
        Console.WriteLine($"Первый наблюдатель получил: {message}");
    }

    public void AlternativeReaction(string message)
    {
        Console.WriteLine($"Альтернативная реакция первого наблюдателя: {message.ToUpper()}");
    }
}

// Второй класс-наблюдатель
class SecondObserver
{
    public void RespondToEvent(string message)
    {
        Console.WriteLine($"Второй наблюдатель отвечает: <<{message}>>");
    }
}

class Program
{
    static void Main()
    {
        // Создаем объекты
        var publisher = new EventPublisher();
        var observer1 = new FirstObserver();
        var observer2 = new SecondObserver();

        // Добавляем обработчики
        publisher.NotifyEvent += observer1.ReactToEvent;
        publisher.NotifyEvent += observer1.AlternativeReaction;
        publisher.NotifyEvent += observer2.RespondToEvent;

        Console.WriteLine("=== Все обработчики добавлены ===");
        publisher.RaiseEvent("Первое сообщение");

        // Удаляем один обработчик
        publisher.NotifyEvent -= observer1.AlternativeReaction;

        Console.WriteLine("\n=== Один обработчик удален ===");
        publisher.RaiseEvent("Второе сообщение");
    }
}