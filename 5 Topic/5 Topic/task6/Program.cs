using System;

class Program
{
    static void Main()
    {
        int n = 7, val = 1, top = 0, left = 0, bottom = n - 1, right = n - 1;
        int[,] spiral = new int[n, n];

        while (val <= n * n)
        {
            for (int i = left; i <= right; i++) spiral[top, i] = val++;
            top++;
            for (int i = top; i <= bottom; i++) spiral[i, right] = val++;
            right--;
            for (int i = right; i >= left; i--) spiral[bottom, i] = val++;
            bottom--;
            for (int i = bottom; i >= top; i--) spiral[i, left] = val++;
            left++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(spiral[i, j].ToString("D2") + " ");
            Console.WriteLine();
        }
    }
}
