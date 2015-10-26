/*  Write a method that returns the index of the first element in array that is larger than its neighbours, 
    or -1 if there's no such element. Use the method from the previous exercise in order to re.
*/

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    static int IsLargerThanNeighbours(int[] numbers, int index)
    {
        bool isBigger = false;
        if (index > 0 && index < numbers.Length - 1)
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

        if (isBigger)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
}
