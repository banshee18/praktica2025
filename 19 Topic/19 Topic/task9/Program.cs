using System;

/// <summary>
/// Основной класс программы.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат, который возвращает случайное целое число.
    /// </summary>
    delegate int RandomNumberGenerator();

    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Массив делегатов для генерации случайных чисел.
        /// </summary>
        RandomNumberGenerator[] delegatesArray = new RandomNumberGenerator[5];
        Random random = new Random();

        /// <summary>
        /// Инициализация делегатов, каждый из которых возвращает случайное число от 1 до 100.
        /// </summary>
        for (int i = 0; i < delegatesArray.Length; i++)
        {
            delegatesArray[i] = () => random.Next(1, 101);
        }

        /// <summary>
        /// Анонимный метод для вычисления среднего арифметического случайных чисел.
        /// </summary>
        Func<RandomNumberGenerator[], double> averageCalculator = delegate (RandomNumberGenerator[] delegates)
        {
            if (delegates == null || delegates.Length == 0)
                return 0;

            double sum = 0;
            foreach (var del in delegates)
            {
                sum += del(); // Вызываем каждый делегат и суммируем результаты
            }
            return sum / delegates.Length; // Возвращаем среднее арифметическое
        };

        // Вызываем анонимный метод для вычисления среднего значения
        double average = averageCalculator(delegatesArray);

        /// <summary>
        /// Вывод сгенерированных чисел в консоль.
        /// </summary>
        Console.WriteLine("Сгенерированные числа:");
        for (int i = 0; i < delegatesArray.Length; i++)
        {
            Console.WriteLine($"Делегат {i + 1}: {delegatesArray[i]()}");
        }

        /// <summary>
        /// Вывод среднего арифметического в консоль.
        /// </summary>
        Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
    }
}
