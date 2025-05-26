using System;
using System.IO;
using System.Linq;

class Program
{
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
            /* ЗАДАНИЕ 1: Замена всех 0 на 1 и наоборот в файле
               Алгоритм:
               1. Читаем исходный файл
               2. В каждой строке меняем 0→1 и 1→0
               3. Записываем результат в новый файл */
            Console.WriteLine("\n=== ЗАДАНИЕ 1 ===");
            string sourceFile = "source.txt";
            string resultFile = "result_01.txt";

            // Если файла нет - создаем пример
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("[Создаю пример файла source.txt]");
                File.WriteAllLines(sourceFile, new[] { "010101", "101010", "000111", "111000" });
            }

            // Чтение файла и замена символов
            var lines = File.ReadAllLines(sourceFile)
                .Select(line => line.Replace('0', '\t')  // Временная замена 0→tab
                                   .Replace('1', '0')    // Замена 1→0
                                   .Replace('\t', '1'))  // Замена tab→1
                .ToArray();

            // Запись результата
            File.WriteAllLines(resultFile, lines);
            Console.WriteLine($"Результат сохранен в файл: {resultFile}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(string.Join("\n", lines));

            /* ЗАДАНИЕ 2: Разделение строк файла на четные и нечетные
               Алгоритм:
               1. Читаем все строки из файла
               2. Четные строки (с нечетными индексами 1,3,5...) записываем в файл A
               3. Нечетные строки (с четными индексами 0,2,4...) записываем в файл B */
            Console.WriteLine("\n=== ЗАДАНИЕ 2 ===");
            string evenFile = "even_lines.txt"; // Для четных строк
            string oddFile = "odd_lines.txt";   // Для нечетных строк

            // Чтение исходного файла
            var allLines = File.ReadAllLines(sourceFile);

            // Разделение строк (индексация с 0!)
            var evenLines = allLines.Where((line, index) => index % 2 == 1).ToArray(); // Четные
            var oddLines = allLines.Where((line, index) => index % 2 == 0).ToArray();  // Нечетные

            // Запись результатов
            File.WriteAllLines(evenFile, evenLines);
            File.WriteAllLines(oddFile, oddLines);
            Console.WriteLine($"Четные строки сохранены в: {evenFile}");
            Console.WriteLine($"Нечетные строки сохранены в: {oddFile}");

            /* ЗАДАНИЕ 3: Обмен содержимым между двумя файлами
               Алгоритм:
               1. Создаем временный файл
               2. Перемещаем fileA → temp
               3. Перемещаем fileB → fileA
               4. Перемещаем temp → fileB */
            Console.WriteLine("\n=== ЗАДАНИЕ 3 ===");
            string fileA = "fileA.txt";
            string fileB = "fileB.txt";

            // Создаем пример файлов если их нет
            if (!File.Exists(fileA) || !File.Exists(fileB))
            {
                Console.WriteLine("[Создаю пример файлов для обмена]");
                File.WriteAllLines(fileA, new[] { "Содержимое файла A1", "Содержимое файла A2" });
                File.WriteAllLines(fileB, new[] { "Содержимое файла B1", "Содержимое файла B2" });
            }

            // Выполняем обмен через временный файл
            string tempFile = Path.GetTempFileName();
            File.Move(fileA, tempFile);    // A → temp
            File.Move(fileB, fileA);       // B → A
            File.Move(tempFile, fileB);    // temp → B

            Console.WriteLine($"Файлы {fileA} и {fileB} успешно обменяны местами");

            /* ЗАДАНИЕ 4: Сравнение двух файлов
               Алгоритм:
               1. Проверяем одинаковое ли количество строк
               2. Построчно сравниваем содержимое
               3. Находим первую различающуюся строку */
            Console.WriteLine("\n=== ЗАДАНИЕ 4 ===");

            // Чтение файлов для сравнения
            var linesA = File.ReadAllLines(fileA);
            var linesB = File.ReadAllLines(fileB);

            // Проверка количества строк
            if (linesA.Length != linesB.Length)
            {
                Console.WriteLine($"Файлы имеют разное количество строк: {linesA.Length} vs {linesB.Length}");
            }
            else
            {
                bool identical = true;
                // Построчное сравнение
                for (int i = 0; i < linesA.Length; i++)
                {
                    if (linesA[i] != linesB[i])
                    {
                        Console.WriteLine($"Различие в строке {i + 1}:");
                        Console.WriteLine($"{fileA}: {linesA[i]}");
                        Console.WriteLine($"{fileB}: {linesB[i]}");
                        identical = false;
                        break;
                    }
                }

                if (identical) Console.WriteLine("Файлы полностью идентичны");
            }
        }
        catch (Exception ex)
        {
            // Обработка всех возможных ошибок
            Console.WriteLine($"\nОШИБКА: {ex.Message}");
            Console.WriteLine("Рекомендации:");
            Console.WriteLine("- Проверьте наличие файлов");
            Console.WriteLine("- Убедитесь, что файлы не используются другими программами");
            Console.WriteLine("- Проверьте права доступа к файлам");
        }
        finally
        {
            // Завершение программы
            Console.WriteLine("\n=================================");
            Console.WriteLine("Работа программы завершена");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}