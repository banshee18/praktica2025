using System;
using System.IO;

/// <summary>
/// Класс для выполнения операций с файлами и каталогами.
/// </summary>
class FileOperations
{
    /// <summary>
    /// Главный метод программы.
    /// Выполняет различные операции с файловой системой, включая создание каталогов, копирование файлов, их скрытие и создание ярлыков.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Программа для работы с файлами и каталогами");
        Console.WriteLine("-------------------------------------------");

        try
        {
            /// <summary>
            /// Выводит список всех файлов на локальных дисках.
            /// </summary>
            ListAllFilesOnLocalDrives();

            /// <summary>
            /// Создает каталог Example_38tp на доступном диске.
            /// </summary>
            string targetDrive = GetAvailableDrive();
            string newDirPath = Path.Combine(targetDrive, "Example_38tp");

            Directory.CreateDirectory(newDirPath);
            Console.WriteLine($"\nСоздан каталог: {newDirPath}");

            /// <summary>
            /// Копирует 3 файла из указанного каталога в новый каталог.
            /// </summary>
            string sourceDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Пример");
            CopyThreeFiles(sourceDir, newDirPath);

            /// <summary>
            /// Устанавливает атрибут "Скрытый" для всех файлов в новом каталоге.
            /// </summary>
            SetHiddenAttribute(newDirPath);

            /// <summary>
            /// Создает файлы-ссылки вместо скопированных файлов.
            /// </summary>
            CreateShortcuts(newDirPath);

            Console.WriteLine("\nВсе операции успешно завершены!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Выводит список всех файлов на локальных дисках.
    /// </summary>
    static void ListAllFilesOnLocalDrives()
    {
        Console.WriteLine("\nСписок локальных дисков:");
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo drive in allDrives)
        {
            if (drive.DriveType == DriveType.Fixed)
            {
                Console.WriteLine($"\nДиск {drive.Name} ({drive.DriveFormat}, {drive.TotalSize / (1024 * 1024 * 1024)} GB)");

                try
                {
                    string[] files = Directory.GetFiles(drive.RootDirectory.FullName);
                    Console.WriteLine($"Файлы в корне диска ({files.Length}):");
                    foreach (string file in files.Take(10))
                        Console.WriteLine(Path.GetFileName(file));

                    if (files.Length > 10)
                        Console.WriteLine("... и еще " + (files.Length - 10) + " файлов");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Нет доступа к диску");
                }
            }
        }
    }

    /// <summary>
    /// Получает доступный диск (D, C или E).
    /// </summary>
    /// <returns>Путь к доступному диску.</returns>
    static string GetAvailableDrive()
    {
        string[] drives = { "D:\\", "C:\\", "E:\\" };

        foreach (string drive in drives)
        {
            if (Directory.Exists(drive))
                return drive;
        }

        throw new Exception("Не найден доступный диск для создания каталога");
    }

    /// <summary>
    /// Копирует 3 файла из указанного каталога в целевой каталог.
    /// </summary>
    /// <param name="sourceDir">Источник файлов.</param>
    /// <param name="destDir">Каталог назначения.</param>
    static void CopyThreeFiles(string sourceDir, string destDir)
    {
        if (!Directory.Exists(sourceDir))
        {
            sourceDir = Path.Combine(Path.GetTempPath(), "SourceFiles");
            Directory.CreateDirectory(sourceDir);

            File.WriteAllText(Path.Combine(sourceDir, "file1.txt"), "Тестовый файл 1");
            File.WriteAllText(Path.Combine(sourceDir, "file2.doc"), "Тестовый файл 2");
            File.WriteAllText(Path.Combine(sourceDir, "file3.jpg"), "Тестовый файл 3");
        }

        string[] files = Directory.GetFiles(sourceDir).Take(3).ToArray();

        Console.WriteLine($"\nКопируем файлы из {sourceDir}:");
        foreach (string file in files)
        {
            string destFile = Path.Combine(destDir, Path.GetFileName(file));
            File.Copy(file, destFile, true);
            Console.WriteLine($"Скопирован: {Path.GetFileName(file)}");
        }
    }

    /// <summary>
    /// Устанавливает атрибут "Скрытый" для всех файлов в указанном каталоге.
    /// </summary>
    /// <param name="dirPath">Путь к каталогу.</param>
    static void SetHiddenAttribute(string dirPath)
    {
        Console.WriteLine("\nУстанавливаем атрибут 'Скрытый' для файлов:");
        foreach (string file in Directory.GetFiles(dirPath))
        {
            File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
            Console.WriteLine($"Скрыт: {Path.GetFileName(file)}");
        }
    }

    /// <summary>
    /// Создает файлы-ссылки (ярлыки) на файлы внутри указанного каталога.
    /// </summary>
    /// <param name="dirPath">Путь к каталогу, содержащему файлы.</param>
    static void CreateShortcuts(string dirPath)
    {
        Console.WriteLine("\nСоздаем файлы-ссылки:");

        foreach (string file in Directory.GetFiles(dirPath))
        {
            string shortcutPath = Path.Combine(dirPath,
                Path.GetFileNameWithoutExtension(file) + "_link.lnk");

            string vbsScript = $@"
                Set ws = WScript.CreateObject(""WScript.Shell"")
                Set shortcut = ws.CreateShortcut(""{shortcutPath}"")
                shortcut.TargetPath = ""{file}""
                shortcut.Save
            ";

            string scriptFile = Path.Combine(Path.GetTempPath(), "createshortcut.vbs");
            File.WriteAllText(scriptFile, vbsScript);

            System.Diagnostics.Process.Start("wscript.exe", scriptFile).WaitForExit();
            File.Delete(scriptFile);

            Console.WriteLine($"Создана ссылка: {Path.GetFileName(shortcutPath)}");
        }
    }
}
