using System;

class Program
{
    // Объявляем делегат для методов, возвращающих строки
    delegate string MessageDelegate();

    // Метод 1: Возвращает приветствие
    static string GetGreeting()
    {
        return "Добро пожаловать в нашу программу!";
    }

    // Метод 2: Возвращает текущую дату
    static string GetCurrentDate()
    {
        return $"Сегодня: {DateTime.Now.ToShortDateString()}";
    }

    // Метод 3: Возвращает случайное число
    static string GetRandomNumber()
    {
        Random rnd = new Random();
        return $"Случайное число: {rnd.Next(1, 100)}";
    }

    // Новый метод, принимающий делегат в качестве параметра
    static void ProcessMessages(MessageDelegate messageProcessor)
    {
        try
        {
            Console.WriteLine("\nНачало обработки сообщений...");

            // Проверяем, что делегат не пустой
            if (messageProcessor == null)
            {
                throw new ArgumentNullException(nameof(messageProcessor), "Делегат не может быть null");
            }

            // Получаем список методов из делегата
            var delegateList = messageProcessor.GetInvocationList();

            // Вызываем каждый метод и обрабатываем возможные исключения
            foreach (MessageDelegate del in delegateList)
            {
                try
                {
                    string result = del();
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении метода: {ex.Message}");
                }
            }

            Console.WriteLine("Обработка сообщений завершена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Критическая ошибка: {ex.Message}");
        }
    }

    static void Main()
    {
        try
        {
            // Создаем экземпляр делегата
            MessageDelegate messageDelegate = null;

            // Добавляем методы в делегат
            messageDelegate += GetGreeting;
            messageDelegate += GetCurrentDate;
            messageDelegate += GetRandomNumber;

            // Вызываем новый метод, передавая ему делегат
            ProcessMessages(messageDelegate);

            // Дополнительный пример: создаем новый делегат с одним методом
            MessageDelegate singleDelegate = GetCurrentDate;
            Console.WriteLine("\nТест с одним методом в делегате:");
            ProcessMessages(singleDelegate);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}