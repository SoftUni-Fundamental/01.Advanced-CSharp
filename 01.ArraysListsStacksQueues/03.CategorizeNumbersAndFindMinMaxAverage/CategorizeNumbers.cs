/*  Write a program that reads N floating-point numbers from the console. 
    Your task is to separate them in two sets:
        * one containing only the round numbers (e.g. 1, 1.00, etc.) 
        * and the other containing the floating-point numbers with non-zero fraction. 
    Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).   */

using System;
using System.Linq;
using System.Collections.Generic;

class CategorizeNumbers
{
    static void Main()
    {
        // input:  1.2 -4 5.00 12211 93.003 4 2.2
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<double> rounds = new List<double>();
        List<double> floats = new List<double>();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                rounds.Add(numbers[i]);
            }
            else
            {
                floats.Add(numbers[i]);
            }
        }
        PrintOutput(rounds);
        PrintOutput(floats);
    }

    private static void PrintOutput(List<double> list)
    {
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F}",
            string.Join(", ", list), list.Min(), list.Max(), list.Sum(), list.Average());
    }
}

/*
    Example:
    [1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
     [-4, 5, 12211, 4] -> min: -4, max: 12211, sum: 12216, avg: 3054.00
 */