using System;

// Класс, содержащий информацию о имени
class MyInfo
{
    private string _name;  // Поле для хранения имени

    // Событие, возникающее при изменении имени
    public event Action<string, string> NameChanged;

    // Свойство для работы с именем
    public string Name
    {
        get => _name;
        set
        {
            if (_name != value)  // Проверяем, действительно ли имя изменилось
            {
                string oldName = _name;  // Сохраняем старое имя
                _name = value;          // Устанавливаем новое имя

                // Вызываем событие, передавая старое и новое имя
                NameChanged?.Invoke(oldName, _name);
            }
        }
    }

    // Конструктор класса
    public MyInfo(string name)
    {
        _name = name;
    }
}

class Program
{
    static void Main()
    {
        // Создаем экземпляр класса
        MyInfo myInfo = new MyInfo("Александр");

        // Подписываемся на событие изменения имени
        myInfo.NameChanged += (oldName, newName) =>
        {
            Console.WriteLine($"Имя изменено с '{oldName ?? "null"}' на '{newName}'");
        };

        // Меняем имя (вызовет событие)
        myInfo.Name = "Алексей";

        // Меняем на то же имя (событие не вызовется)
        myInfo.Name = "Алексей";

        // Меняем снова (вызовет событие)
        myInfo.Name = "Сергей";
    }
}