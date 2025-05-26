using System;

class Program
{
    static void Main()
    {
        // Размеры дома
        const int Floors = 12; // Количество этажей
        const int ApartmentsPerFloor = 4; // Количество квартир на этаже

        // Заполнение данных о жильцах
        int[,] residents = new int[Floors, ApartmentsPerFloor];
        Random random = new Random();

        for (int i = 0; i < Floors; i++)
        {
            for (int j = 0; j < ApartmentsPerFloor; j++)
            {
                residents[i, j] = random.Next(1, 10); // Генерация случайного числа жильцов от 1 до 9
            }
        }

        // Вывод информации о жильцах
        Console.WriteLine("Данные о жильцах в доме:");
        PrintMatrix(residents);

        // Нахождение самой большой семьи на 3 и 4 этажах
        int maxResidents = 0;
        for (int i = 2; i <= 3; i++) // Индексы 3-го и 4-го этажей
        {
            for (int j = 0; j < ApartmentsPerFloor; j++)
            {
                if (residents[i, j] > maxResidents)
                {
                    maxResidents = residents[i, j];
                }
            }
        }

        Console.WriteLine($"\nЧисленность самой большой семьи на 3 и 4 этажах: {maxResidents}");
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
