/*  Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist)
*/

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    static bool IsLargerThanNeighbours(int[] numbers, int index)
    {
        bool isBigger = false;
        if (index > 0 && index < numbers.Length-1)
        {
            isBigger = (numbers[index] > numbers[index - 1]) && (numbers[index] > numbers[index + 1]);
        }
        else if (index == 0)
        {
            isBigger = numbers[index] > numbers[index + 1];
        }
        else
        {
            isBigger = numbers[index] > numbers[index - 1];
        }
        return isBigger;
    }
}
