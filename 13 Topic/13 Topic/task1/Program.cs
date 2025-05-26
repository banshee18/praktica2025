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

            // Проверяем, что делегат не пустой
            if (messageDelegate == null)
            {
                throw new NullReferenceException("Делегат не содержит методов!");
            }

            // Получаем список методов из делегата
            var delegateList = messageDelegate.GetInvocationList();

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
