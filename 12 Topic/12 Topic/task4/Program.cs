using System;

class Program
{
    // Объявляем тип делегата, который возвращает случайное целое число
    delegate int RandomNumberGenerator();

    static void Main()
    {
        // Создаем массив делегатов
        RandomNumberGenerator[] delegatesArray = new RandomNumberGenerator[5];
        Random random = new Random();

        // Инициализируем делегаты в массиве (каждый возвращает случайное число)
        for (int i = 0; i < delegatesArray.Length; i++)
        {
            delegatesArray[i] = () => random.Next(1, 101); // Генерация чисел от 1 до 100
        }

        // Создаем анонимный метод для вычисления среднего арифметического
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

        // Вызываем анонимный метод для вычисления среднего
        double average = averageCalculator(delegatesArray);

        // Выводим результаты
        Console.WriteLine("Сгенерированные числа:");
        for (int i = 0; i < delegatesArray.Length; i++)
        {
            Console.WriteLine($"Делегат {i + 1}: {delegatesArray[i]()}");
        }

        Console.WriteLine($"\nСреднее арифметическое: {average:F2}");
    }
}