using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Путь к новой папке (в текущей директории)
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "New_folder");

            // Создание папки
            Directory.CreateDirectory(folderPath);

            Console.WriteLine($"Папка успешно создана: {folderPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
        }
    }
}