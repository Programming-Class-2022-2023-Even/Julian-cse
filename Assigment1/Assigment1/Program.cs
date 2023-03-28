using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

        Console.WriteLine("Output 1 (row-wise): ");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }

        Console.WriteLine("\nOutput 2 (column-wise): ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
    }
}
