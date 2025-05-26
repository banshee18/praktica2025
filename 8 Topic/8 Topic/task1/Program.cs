using System;
using System.Linq;

struct NOTE
{
    public string LastName; // Фамилия
    public string FirstName; // Имя
    public string PhoneNumber; // Номер телефона
    public int[] BirthDate; // Дата рождения (массив из трех чисел)

    public NOTE(string lastName, string firstName, string phoneNumber, int[] birthDate)
    {
        LastName = lastName;
        FirstName = firstName;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}, Имя: {FirstName}, Телефон: {PhoneNumber}, Дата рождения: {BirthDate[0]}.{BirthDate[1]}.{BirthDate[2]}");
    }
}

class Program
{
    static void Main()
    {
        const int size = 4; // Изменено количество записей
        NOTE[] notes = new NOTE[size];

        // Ввод данных с клавиатуры
        Console.WriteLine($"Введите данные для {size} записей:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Запись {i + 1}:");
            Console.Write("Фамилия: ");
            string lastName = Console.ReadLine()?.Trim();
            Console.Write("Имя: ");
            string firstName = Console.ReadLine()?.Trim();
            Console.Write("Номер телефона: ");
            string phoneNumber = Console.ReadLine()?.Trim();
            Console.WriteLine("Дата рождения (день, месяц, год): ");
            int[] birthDate = new int[3];
            for (int j = 0; j < 3; j++)
            {
                birthDate[j] = int.Parse(Console.ReadLine());
            }
            notes[i] = new NOTE(lastName, firstName, phoneNumber, birthDate);
        }

        // Сортировка массива по первым трём цифрам номера телефона
        notes = notes.OrderBy(note => note.PhoneNumber.Substring(0, 3)).ToArray();

        // Вывод данных
        Console.WriteLine("\nОтсортированные записи:");
        foreach (var note in notes)
        {
            note.PrintInfo();
        }

        // Поиск записи по фамилии
        Console.WriteLine("\nВведите фамилию для поиска:");
        string searchLastName = Console.ReadLine()?.Trim();
        var foundNote = notes.FirstOrDefault(note => string.Equals(note.LastName, searchLastName, StringComparison.OrdinalIgnoreCase));

        if (foundNote.LastName != null)
        {
            Console.WriteLine("Найденная запись:");
            foundNote.PrintInfo();
        }
        else
        {
            Console.WriteLine("Запись с указанной фамилией не найдена.");
        }
    }
}
