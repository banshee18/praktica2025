using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для анализа успеваемости учеников.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы.
    /// Читает данные из файлов, выполняет анализ успеваемости и выводит результаты.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Анализ успеваемости класса");
        Console.WriteLine("--------------------------");

        try
        {
            /// <summary>
            /// Чтение данных об оценках учеников из файла mark.txt.
            /// </summary>
            var students = ReadStudentData("mark.txt");

            /// <summary>
            /// Чтение названий предметов из файла Subjects.txt.
            /// </summary>
            var subjects = ReadSubjects("Subjects.txt");

            /// <summary>
            /// Вывод списка отличников (ученики, у которых все оценки ≥ 9).
            /// </summary>
            Console.WriteLine("\nОтличники класса:");
            var excellentStudents = students.Where(s => s.Grades.All(g => g >= 9));
            foreach (var student in excellentStudents)
                Console.WriteLine(student.LastName);

            /// <summary>
            /// Расчет средней оценки по каждому предмету.
            /// </summary>
            Console.WriteLine("\nСредние оценки по предметам:");
            for (int i = 0; i < subjects.Length; i++)
            {
                double avg = students.Average(s => s.Grades[i]);
                Console.WriteLine($"{subjects[i]}: {avg:F2}");
            }

            /// <summary>
            /// Создание файла со средними баллами учеников (по убыванию).
            /// </summary>
            CreateStudentAveragesFile(students, "averages.txt");
            Console.WriteLine("\nФайл со средними баллами создан: averages.txt");
        }
        catch (FileNotFoundException ex)
        {
            /// <summary>
            /// Обработка ошибки отсутствия файла.
            /// </summary>
            Console.WriteLine($"Ошибка: файл {ex.FileName} не найден");
        }
        catch (Exception ex)
        {
            /// <summary>
            /// Обработка прочих ошибок программы.
            /// </summary>
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Читает данные об учениках и их оценках из файла.
    /// </summary>
    /// <param name="filePath">Путь к файлу с данными об учениках.</param>
    /// <returns>Список учеников с их оценками.</returns>
    static List<Student> ReadStudentData(string filePath)
    {
        var students = new List<Student>();
        foreach (string line in File.ReadAllLines(filePath))
        {
            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 11) continue;

            students.Add(new Student
            {
                LastName = parts[0],
                Grades = parts.Skip(1).Select(int.Parse).ToArray()
            });
        }
        return students;
    }

    /// <summary>
    /// Читает список названий предметов из файла.
    /// </summary>
    /// <param name="filePath">Путь к файлу с названиями предметов.</param>
    /// <returns>Массив названий предметов.</returns>
    static string[] ReadSubjects(string filePath)
    {
        return File.ReadAllLines(filePath)
                  .Select(line => line.Split(new[] { '.' }, 2)[1].Trim())
                  .ToArray();
    }

    /// <summary>
    /// Создает файл со средними баллами учеников, отсортированными по убыванию.
    /// </summary>
    /// <param name="students">Список учеников.</param>
    /// <param name="outputPath">Путь к файлу для сохранения результатов.</param>
    static void CreateStudentAveragesFile(List<Student> students, string outputPath)
    {
        var studentAverages = students
            .Select(s => new {
                s.LastName,
                Average = s.Grades.Average()
            })
            .OrderByDescending(s => s.Average)
            .ToList();

        File.WriteAllLines(outputPath,
            studentAverages.Select(s => $"{s.LastName} {s.Average:F2}"));
    }
}

/// <summary>
/// Класс для хранения информации об ученике.
/// </summary>
class Student
{
    /// <summary>
    /// Фамилия ученика.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Оценки ученика по всем предметам.
    /// </summary>
    public int[] Grades { get; set; }
}
