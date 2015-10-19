/*  We are given a matrix of strings of size N x M. 
    Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. 
    Write a program that finds the longest sequence of equal strings in the matrix.     */

using System;
using System.Collections.Generic;

class SequenceInMatrix
{
    static void Main()
    {
        int mRow = int.Parse(Console.ReadLine());
        int mCol = int.Parse(Console.ReadLine());
        string[,] matrix = new string[mRow, mCol];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        //PrintMatrix(matrix);

        List<string> longest = new List<string>();
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                List<string> sequence = new List<string>();

                sequence = Horizontal(matrix, row, col);
                if (sequence.Count > longest.Count)
                {
                    longest = sequence;
                }

                sequence = Vertical(matrix, row, col);
                if (sequence.Count > longest.Count)
                {
                    longest = sequence;
                }

                sequence = Diagonal(matrix, row, col);
                if (sequence.Count > longest.Count)
                {
                    longest = sequence;
                }
            }
        }

        Console.WriteLine("{0}", string.Join(", ", longest));
    }

    static List<string> Horizontal(string[,] matrix, int row, int col)
    {
        int count = 0;
        List<string> sequence = new List<string>();

        while (count + col < matrix.GetLength(1))
        {
            bool equalLine = (matrix[row, (col + count)]) == matrix[row, col];
            if (equalLine)
            {
                sequence.Add(matrix[row, (col + count)]);
                count++;
            }
            else
            {
                break;
            }
        }
        return sequence;
    }

    static List<string> Vertical(string[,] matrix, int row, int col)
    {
        int count = 0;
        List<string> sequence = new List<string>();

        while (count + row < matrix.GetLength(0))
        {
            bool equalLine = (matrix[(row + count), col]) == matrix[row, col];
            if (equalLine)
            {
                sequence.Add(matrix[(row + count), col]);
                count++;
            }
            else
            {
                break;
            }
        }
        return sequence;
    }
    
    static List<string> Diagonal(string[,] matrix, int row, int col)
    {
        int count = 0;
        List<string> sequence = new List<string>();

        while (count + row < matrix.GetLength(0) && count + col < matrix.GetLength(1))
        {
            bool equalDiagonal = (matrix[(row + count), (col + count)]) == matrix[row, col];
            if (equalDiagonal)
            {
                sequence.Add(matrix[(row + count), (col + count)]);
                count++;
            }
            else
            {
                break;
            }
        }

        return sequence;
    }

    static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


/*
3
4
ha
fifi
ho
hi
fo
ha
hi
xx
xxx
ho
ha
xx
 */


/*
3
3
s
qq
s
pp
pp
s
pp
qq
s
*/