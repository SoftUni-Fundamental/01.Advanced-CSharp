using System;
using System.Collections.Generic;
using System.Linq;

class MatrixShuffling
{
    static void Main()
    {
        /*
         Write a program which reads a string matrix from the console and performs certain operations with its elements. 
         User input is provided in a similar way like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later. 
         */
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        while (true)
        {
            Console.WriteLine();
            List<string> input = Console.ReadLine().Split(' ').ToList();
            //  swap 0 0 1 1
            if (input[0].ToLower() == "swap" && input.Count == 5)
            {
                bool validValues = CheckSwapIndexes(input, rows, cols);
                if (validValues)
                {
                    input.RemoveAt(0);
                    int[] arrOfIndex = ConvertToInts(input);
                    
                    string swapNumb = matrix[arrOfIndex[0], arrOfIndex[1]];
                    matrix[arrOfIndex[0], arrOfIndex[1]] = matrix[arrOfIndex[2], arrOfIndex[3]];
                    matrix[arrOfIndex[2], arrOfIndex[3]] = swapNumb;
                    
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else if (input[0].ToUpper() == "END")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static int[] ConvertToInts(List<string> input)
    {
        int[] arr = new int[4];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }
        
        return arr;
    }

    static bool CheckSwapIndexes(List<string> input, int rows, int cols)
    {
        bool checker = false;
        for (int i = 1; i < input.Count; i++)
        {
            if (i % 2 == 1)
            {
                checker = int.Parse(input[i]) >= 0 && int.Parse(input[i]) < rows;
            }
            else
            {
                checker = int.Parse(input[i]) >= 0 && int.Parse(input[i]) < cols;
            }
            if (checker == false)
            {
                return checker;
            }
        }
        return checker;
    }
}
