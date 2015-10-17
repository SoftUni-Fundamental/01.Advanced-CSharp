/*  Write two programs that fill and print a matrix of size N x N. 
    Filling a matrix in the regular pattern (top to bottom and left to right) is boring.
        *Fill the matrix as described in both patterns below: ...
*/

using System;

class FillTheMatrix
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] firstPattern = new int[size, size];
        int[,] secondPattern = new int[size, size];

        int countFirst = 0;
        int countSecond = 0;
        for (int col = 0; col < firstPattern.GetLength(1); col++)
        {
            if (col % 2 == 1)
            {
                for (int row = secondPattern.GetLength(0) - 1; row >= 0; row--)
                {
                    secondPattern[row, col] = ++countSecond;
                }
            }
            for (int row = 0; row < firstPattern.GetLength(0); row++)
            {
                firstPattern[row, col] = ++countFirst;
                if (col % 2 == 0)
                {
                    secondPattern[row, col] = ++countSecond;
                }
            }
        }

        PrintMatrix(firstPattern);
        Console.WriteLine();
        PrintMatrix(secondPattern);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int lng = (matrix.GetLength(0) * matrix.GetLength(0)).ToString().Length + 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}", matrix[row, col].ToString().PadLeft(lng, ' '));
            }
            Console.WriteLine();
        }
    }
}
