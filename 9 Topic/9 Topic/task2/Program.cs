using System;

class StringArray
{
    private readonly string[] _array;
    public readonly int Lower, Upper;

    public StringArray(int lower, int upper)
    {
        if (lower > upper)
            throw new ArgumentException("Нижняя граница должна быть меньше или равна верхней");

        Lower = lower;
        Upper = upper;
        _array = new string[upper - lower + 1];
    }

    public string this[int i]
    {
        get => _array[CheckIndex(i)];
        set => _array[CheckIndex(i)] = value;
    }

    private int CheckIndex(int i)
    {
        if (i < Lower || i > Upper)
            throw new IndexOutOfRangeException($"Индекс {i} вне диапазона [{Lower}..{Upper}]");
        return i - Lower;
    }

    public static StringArray Concat(StringArray a, StringArray b)
    {
        if (a.Upper - a.Lower != b.Upper - b.Lower)
            throw new ArgumentException("Массивы должны иметь одинаковую длину");

        var result = new StringArray(a.Lower, a.Upper);
        for (int i = a.Lower; i <= a.Upper; i++)
            result[i] = a[i] + b[i];
        return result;
    }

    public void Print(int? index = null)
    {
        if (index.HasValue)
            Console.WriteLine($"[{index}]: {this[index.Value]}");
        else
            for (int i = Lower; i <= Upper; i++)
                Console.WriteLine($"[{i}]: {this[i] ?? "null"}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Ввод первого массива
            Console.WriteLine("Создание первого массива");
            var arr1 = CreateArray();

            // Ввод второго массива
            Console.WriteLine("\nСоздание второго массива");
            var arr2 = CreateArray();

            // Вывод результатов
            Console.WriteLine("\nПервый массив:");
            arr1.Print();

            Console.WriteLine("\nВторой массив:");
            arr2.Print();

            Console.WriteLine("\nРезультат сцепления:");
            StringArray.Concat(arr1, arr2).Print();

            Console.Write("\nВведите индекс элемента для вывода: ");
            if (int.TryParse(Console.ReadLine(), out int index))
                StringArray.Concat(arr1, arr2).Print(index);
            else
                Console.WriteLine("Некорректный индекс");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static StringArray CreateArray()
    {
        Console.Write("Введите нижнюю и верхнюю границы через пробел: ");
        var bounds = Console.ReadLine().Split();
        if (bounds.Length != 2 || !int.TryParse(bounds[0], out int lower) || !int.TryParse(bounds[1], out int upper))
            throw new FormatException("Некорректный формат границ");

        var array = new StringArray(lower, upper);

        Console.WriteLine($"Введите {array.Upper - array.Lower + 1} элементов массива:");
        for (int i = array.Lower; i <= array.Upper; i++)
        {
            Console.Write($"[{i}]: ");
            array[i] = Console.ReadLine();
        }

        return array;
    }
}