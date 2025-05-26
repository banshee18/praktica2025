using System;

/// <summary>
/// Класс Matrix представляет матрицу целых чисел и операции над ней
/// </summary>
class Matrix
{
    /// <summary>
    /// Двумерный массив для хранения данных матрицы
    /// </summary>
    private int[,] data;

    /// <summary>
    /// Инициализирует новый экземпляр класса Matrix с указанным массивом
    /// </summary>
    /// <param name="array">Двумерный массив целых чисел для создания матрицы</param>
    /// <exception cref="ArgumentNullException">Выбрасывается, если входной массив равен null</exception>
    public Matrix(int[,] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        data = array;
    }

    /// <summary>
    /// Вычисляет сумму элементов на главной диагонали матрицы
    /// </summary>
    /// <returns>Сумма элементов главной диагонали</returns>
    /// <remarks>
    /// Для прямоугольных матриц учитывается только квадратная часть (минимальный размер)
    /// </remarks>
    public int GetMainDiagonalSum()
    {
        int sum = 0;
        int size = Math.Min(data.GetLength(0), data.GetLength(1));
        for (int i = 0; i < size; i++)
        {
            sum += data[i, i];
        }
        return sum;
    }

    /// <summary>
    /// Перегруженный оператор "больше" для сравнения матриц по сумме главной диагонали
    /// </summary>
    /// <param name="m1">Первая матрица для сравнения</param>
    /// <param name="m2">Вторая матрица для сравнения</param>
    /// <returns>True, если сумма главной диагонали первой матрицы больше</returns>
    public static bool operator >(Matrix m1, Matrix m2)
    {
        return m1.GetMainDiagonalSum() > m2.GetMainDiagonalSum();
    }

    /// <summary>
    /// Перегруженный оператор "меньше" для сравнения матриц по сумме главной диагонали
    /// </summary>
    /// <param name="m1">Первая матрица для сравнения</param>
    /// <param name="m2">Вторая матрица для сравнения</param>
    /// <returns>True, если сумма главной диагонали первой матрицы меньше</returns>
    public static bool operator <(Matrix m1, Matrix m2)
    {
        return m1.GetMainDiagonalSum() < m2.GetMainDiagonalSum();
    }

    /// <summary>
    /// Выводит матрицу в консоль в табличном формате
    /// </summary>
    public void DisplayMatrix()
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write(data[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

/// <summary>
/// Главный класс программы для демонстрации работы с матрицами
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <remarks>
    /// Создает две матрицы, выводит их на экран, вычисляет суммы главных диагоналей
    /// и сравнивает матрицы с использованием перегруженных операторов
    /// </remarks>
    static void Main()
    {
        // Создание и инициализация первого массива
        int[,] array1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        Matrix matrix1 = new Matrix(array1);

        // Создание и инициализация второго массива
        int[,] array2 = {
            { 3, 2, 1 },
            { 6, 5, 4 },
            { 9, 8, 7 }
        };
        Matrix matrix2 = new Matrix(array2);

        // Вывод массивов
        Console.WriteLine("Первая матрица:");
        matrix1.DisplayMatrix();
        Console.WriteLine($"\nСумма главной диагонали: {matrix1.GetMainDiagonalSum()}");

        Console.WriteLine("\nВторая матрица:");
        matrix2.DisplayMatrix();
        Console.WriteLine($"\nСумма главной диагонали: {matrix2.GetMainDiagonalSum()}");

        // Сравнение массивов с использованием перегруженных операций
        Console.WriteLine("\nСравнение матриц:");
        if (matrix1 > matrix2)
            Console.WriteLine("Сумма главной диагонали первой матрицы больше, чем у второй.");
        else if (matrix1 < matrix2)
            Console.WriteLine("Сумма главной диагонали второй матрицы больше, чем у первой.");
        else
            Console.WriteLine("Суммы главных диагоналей матриц равны.");
    }
}