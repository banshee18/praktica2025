using System;

/// <summary>
/// Программа-калькулятор, демонстрирующая использование делегатов для арифметических операций
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для выполнения арифметических операций с двумя числами
    /// </summary>
    /// <param name="x">Первое число (операнд)</param>
    /// <param name="y">Второе число (операнд)</param>
    /// <returns>Результат арифметической операции</returns>
    delegate double ArithmeticOperation(double x, double y);

    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <remarks>
    /// Программа выполняет следующие действия:
    /// 1. Определяет 4 лямбда-оператора для основных арифметических операций
    /// 2. Запрашивает у пользователя два числа и операцию
    /// 3. Выполняет выбранную операцию через соответствующий делегат
    /// 4. Выводит результат с форматированием
    /// 5. Обрабатывает возможные исключения (деление на ноль, неверный формат ввода)
    /// </remarks>
    static void Main()
    {
        // Определяем лямбда-операторы для арифметических операций
        ArithmeticOperation Add = (x, y) => x + y;
        ArithmeticOperation Sub = (x, y) => x - y;
        ArithmeticOperation Mul = (x, y) => x * y;
        ArithmeticOperation Div = (x, y) =>
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Ошибка: деление на ноль!");
            }
            return x / y;
        };

        try
        {
            // Ввод данных от пользователя
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Выберите операцию (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Выполнение выбранной операции
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Sub(num1, num2);
                    break;
                case '*':
                    result = Mul(num1, num2);
                    break;
                case '/':
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    return;
            }

            // Вывод результата
            Console.WriteLine($"Результат: {result:F0}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено нечисловое значение!");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}