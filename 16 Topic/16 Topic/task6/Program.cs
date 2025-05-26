using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Анализ успеваемости класса");
        Console.WriteLine("--------------------------");

        try
        {
            // 1. Чтение данных об оценках
            var students = ReadStudentData("mark.txt");

            // 2. Чтение названий предметов
            var subjects = ReadSubjects("Subjects.txt");

            // 3. Вывод отличников (все оценки ≥ 9)
            Console.WriteLine("\nОтличники класса:");
            var excellentStudents = students.Where(s => s.Grades.All(g => g >= 9));
            foreach (var student in excellentStudents)
                Console.WriteLine(student.LastName);

            // 4. Расчет средней оценки по каждому предмету
            Console.WriteLine("\nСредние оценки по предметам:");
            for (int i = 0; i < 10; i++)
            {
                double avg = students.Average(s => s.Grades[i]);
                Console.WriteLine($"{subjects[i]}: {avg:F2}");
            }

            // 5. Создание файла с средними баллами (по убыванию)
            CreateStudentAveragesFile(students, "averages.txt");
            Console.WriteLine("\nФайл со средними баллами создан: averages.txt");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"Ошибка: файл {ex.FileName} не найден");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }

    // Чтение данных об учениках и их оценках
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

    // Чтение названий предметов
    static string[] ReadSubjects(string filePath)
    {
        return File.ReadAllLines(filePath)
                  .Select(line => line.Split(new[] { '.' }, 2)[1].Trim())
                  .ToArray();
    }

    // Создание файла со средними баллами (по убыванию)
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

// Класс для хранения данных об ученике
class Student
{
    public string LastName { get; set; }
    public int[] Grades { get; set; }
}