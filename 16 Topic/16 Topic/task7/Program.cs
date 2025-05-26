using System;
using System.IO;

class FileOperations
{
    static void Main()
    {
        Console.WriteLine("Программа для работы с файлами и каталогами");
        Console.WriteLine("-------------------------------------------");

        try
        {
            // 1. Вывод списка всех файлов на локальных дисках
            ListAllFilesOnLocalDrives();

            // 2. Создание каталога Example_38tp на диске D (или C если D недоступен)
            string targetDrive = GetAvailableDrive();
            string newDirPath = Path.Combine(targetDrive, "Example_38tp");

            Directory.CreateDirectory(newDirPath);
            Console.WriteLine($"\nСоздан каталог: {newDirPath}");

            // 3. Копирование 3 разных файлов из другого каталога
            string sourceDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Пример");
            CopyThreeFiles(sourceDir, newDirPath);

            // 4. Изменение атрибутов скопированных файлов на "Скрытый"
            SetHiddenAttribute(newDirPath);

            // 5. Создание файлов-ссылок вместо скопированных файлов
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

    // 1. Вывод списка всех файлов на локальных дисках
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
                    // Выводим только файлы в корне диска (для скорости)
                    string[] files = Directory.GetFiles(drive.RootDirectory.FullName);
                    Console.WriteLine($"Файлы в корне диска ({files.Length}):");
                    foreach (string file in files.Take(10)) // Ограничиваем вывод
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

    // 2. Получение доступного диска (D, или C если D недоступен)
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

    // 3. Копирование 3 разных файлов из указанного каталога
    static void CopyThreeFiles(string sourceDir, string destDir)
    {
        if (!Directory.Exists(sourceDir))
        {
            // Создаем тестовые файлы, если исходный каталог не существует
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

    // 4. Установка атрибута "Скрытый" для всех файлов в каталоге
    static void SetHiddenAttribute(string dirPath)
    {
        Console.WriteLine("\nУстанавливаем атрибут 'Скрытый' для файлов:");
        foreach (string file in Directory.GetFiles(dirPath))
        {
            File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
            Console.WriteLine($"Скрыт: {Path.GetFileName(file)}");
        }
    }

    // 5. Создание файлов-ссылок (ярлыков) вместо оригинальных файлов
    static void CreateShortcuts(string dirPath)
    {
        Console.WriteLine("\nСоздаем файлы-ссылки:");

        foreach (string file in Directory.GetFiles(dirPath))
        {
            string shortcutPath = Path.Combine(dirPath,
                Path.GetFileNameWithoutExtension(file) + "_link.lnk");

            // Создаем ярлык с помощью WScript (Windows Script Host)
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