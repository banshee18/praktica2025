using System;

class Matrix
{
    // Скрытое поле для хранения двумерного массива
    private int[,] data;

    // Конструктор для инициализации массива
    public Matrix(int[,] array)
    {
        data = array;
    }

    // Метод для вычисления суммы элементов главной диагонали
    public int GetMainDiagonalSum()
    {
        int sum = 0;
        int size = Math.Min(data.GetLength(0), data.GetLength(1)); // Размер квадратной части матрицы
        for (int i = 0; i < size; i++)
        {
            sum += data[i, i];
        }
        return sum;
    }

    // Перегруженная операция ">"
    public static bool operator >(Matrix m1, Matrix m2)
    {
        return m1.GetMainDiagonalSum() > m2.GetMainDiagonalSum();
    }

    // Перегруженная операция "<"
    public static bool operator <(Matrix m1, Matrix m2)
    {
        return m1.GetMainDiagonalSum() < m2.GetMainDiagonalSum();
    }

    // Метод для отображения массива
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

class Program
{
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
