using System;
using System.IO;

/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// Создает новую папку в текущей директории и обрабатывает возможные ошибки.
    /// </summary>
    static void Main()
    {
        try
        {
            /// <summary>
            /// Определение пути для новой папки.
            /// Папка создается в текущей директории программы.
            /// </summary>
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "New_folder");

            /// <summary>
            /// Создание новой папки по указанному пути.
            /// Если папка уже существует, действие не приведет к ошибке.
            /// </summary>
            Directory.CreateDirectory(folderPath);

            Console.WriteLine($"Папка успешно создана: {folderPath}");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка возможных исключений при создании папки.
            /// Вывод сообщения об ошибке в консоль.
            /// </summary>
            /// <param name="ex">Объект исключения, содержащий информацию об ошибке.</param>
            Console.WriteLine($"Ошибка при создании папки: {ex.Message}");
        }
    }
}
