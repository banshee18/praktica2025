using System;

enum EmployeePosition
{
    Менеджер = 160,       // Менеджер: 160 часов в месяц
    Разработчик = 180,     // Разработчик: 180 часов в месяц
    Дизайнер = 150,      // Дизайнер: 150 часов в месяц
    Тестировщик = 170,        // Тестировщик: 170 часов в месяц
    Стажер = 120         // Стажер: 120 часов в месяц
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Список должностей и их нормы рабочего времени:");

        // Перебор значений перечисления в порядке определения
        foreach (EmployeePosition position in Enum.GetValues(typeof(EmployeePosition)))
        {
            Console.WriteLine($"{position}: {(int)position} часов в месяц");
        }

        Console.WriteLine("\nВведите должность для получения информации:");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out EmployeePosition selectedPosition))
        {
            Console.WriteLine($"Должность: {selectedPosition}, Рабочие часы: {(int)selectedPosition} часов в месяц.");
        }
        else
        {
            Console.WriteLine("Указанная должность не найдена.");
        }
    }
}
