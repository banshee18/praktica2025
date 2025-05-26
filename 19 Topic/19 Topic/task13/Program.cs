using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для обработки текстовых файлов.
/// Выполняет замену символов, разделение строк, обмен содержимым и сравнение файлов.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// Включает выполнение четырёх заданий по обработке текстовых файлов.
    /// </summary>
    static void Main()
    {
        // Вывод заголовка программы
        Console.WriteLine("Программа для обработки текстовых файлов");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Выполняет 4 задания:");
        Console.WriteLine("1. Замена 0 и 1 в файле");
        Console.WriteLine("2. Разделение на четные/нечетные строки");
        Console.WriteLine("3. Обмен содержимым между файлами");
        Console.WriteLine("4. Сравнение содержимого файлов");
        Console.WriteLine("---------------------------------------");

        try
        {
            /// <summary>
            /// Задание 1: Замена всех 0 на 1 и наоборот в файле.
            /// Читает строки из исходного файла, выполняет замену символов и записывает результат в новый файл.
            /// </summary>
            string sourceFile = "source.txt";
            string resultFile = "result_01.txt";

            if (!File.Exists(sourceFile))
                File.WriteAllLines(sourceFile, new[] { "010101", "101010", "000111", "111000" });

            var lines = File.ReadAllLines(sourceFile)
                .Select(line => line.Replace('0', '\t').Replace('1', '0').Replace('\t', '1'))
                .ToArray();

            File.WriteAllLines(resultFile, lines);
            Console.WriteLine($"Результат сохранен в файл: {resultFile}");

            /// <summary>
            /// Задание 2: Разделение строк исходного файла на четные и нечетные строки.
            /// Четные строки записываются в один файл, нечетные - в другой.
            /// </summary>
            string evenFile = "even_lines.txt";
            string oddFile = "odd_lines.txt";

            var allLines = File.ReadAllLines(sourceFile);
            var evenLines = allLines.Where((line, index) => index % 2 == 1).ToArray();
            var oddLines = allLines.Where((line, index) => index % 2 == 0).ToArray();

            File.WriteAllLines(evenFile, evenLines);
            File.WriteAllLines(oddFile, oddLines);

            /// <summary>
            /// Задание 3: Обмен содержимым между двумя файлами.
            /// Осуществляет обмен содержимым между fileA и fileB через временный файл.
            /// </summary>
            string fileA = "fileA.txt";
            string fileB = "fileB.txt";

            if (!File.Exists(fileA) || !File.Exists(fileB))
            {
                File.WriteAllLines(fileA, new[] { "Содержимое файла A1", "Содержимое файла A2" });
                File.WriteAllLines(fileB, new[] { "Содержимое файла B1", "Содержимое файла B2" });
            }

            string tempFile = Path.GetTempFileName();
            File.Move(fileA, tempFile);
            File.Move(fileB, fileA);
            File.Move(tempFile, fileB);

            /// <summary>
            /// Задание 4: Сравнение двух файлов построчно.
            /// Проверяет количество строк и выводит первую строку, где обнаружено различие.
            /// </summary>
            var linesA = File.ReadAllLines(fileA);
            var linesB = File.ReadAllLines(fileB);

            if (linesA.Length != linesB.Length)
                Console.WriteLine($"Файлы имеют разное количество строк: {linesA.Length} vs {linesB.Length}");
            else
            {
                for (int i = 0; i < linesA.Length; i++)
                {
                    if (linesA[i] != linesB[i])
                    {
                        Console.WriteLine($"Различие в строке {i + 1}: {linesA[i]} vs {linesB[i]}");
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка всех возможных исключений, связанных с обработкой файлов.
            /// Выводит сообщение об ошибке и рекомендации.
            /// </summary>
            Console.WriteLine($"\nОШИБКА: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine("Работа программы завершена.");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
