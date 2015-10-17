/*  Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
    On the first line, you will receive the rows N and columns M. 
    On the next N lines you will receive each row with its columns.
    Print the elements of the 3 x 3 square as a matrix, along with their sum.
*/

using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[size[0], size[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] numsInRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = numsInRow[col];
            }
        }
        //PrintTheMatrix(matrix);

        int[,] sqreMatrix = new int[3, 3];
        int bigSum = int.MinValue;
        int[] bigIndex = { 0, 0 };
        for (int mRow = 0; mRow <= matrix.GetLength(0) - 3; mRow++)
        {
            for (int mCol = 0; mCol <= matrix.GetLength(1) - 3; mCol++)
            {
                int currentSum = 0;
                for (int sqRow = 0; sqRow < sqreMatrix.GetLength(0); sqRow++)
                {
                    for (int sqCol = 0; sqCol < sqreMatrix.GetLength(1); sqCol++)
                    {
                        currentSum += matrix[mRow+sqRow, mCol+sqCol];
                    }
                }
                if (currentSum > bigSum)
                {
                    bigIndex[0] = mRow;
                    bigIndex[1] = mCol;
                    bigSum = currentSum;
                }
            }
        }

        Console.WriteLine("\r\nSum = {0}", bigSum);
        for (int r = 0; r < sqreMatrix.GetLength(0); r++)
        {
            for (int c = 0; c < sqreMatrix.GetLength(1); c++)
            {
                Console.Write("{0,-3}", matrix[(r + bigIndex[0]), (c + bigIndex[1])]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintTheMatrix(int[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write("{0,3}", matrix[r, c]);
            }
            Console.WriteLine();
        }
    }
}
