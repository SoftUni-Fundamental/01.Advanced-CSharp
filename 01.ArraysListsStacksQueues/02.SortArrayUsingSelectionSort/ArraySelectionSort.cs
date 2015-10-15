/*  Write a program to sort an array of numbers and then print them back on the console.
    The numbers should be entered from the console on a single line, separated by a space.  
        * Note: Do not use the built-in sorting method, you should write your own.  */

using System;
using System.Collections.Generic;
using System.Linq;

class ArraySelectionSort
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count- 1; i++)
        {
            int index = i;
            int min = numbers[i];
            bool swap = false;
            for (int col = i+1; col < numbers.Count; col++)
            {
                if (numbers[col] < min)
                {
                    min = numbers[col];
                    index = col;
                    swap = true;
                }
            }
            if (swap)
            {
                numbers.RemoveAt(index);
                numbers.Insert(i, min);
            }   
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}
