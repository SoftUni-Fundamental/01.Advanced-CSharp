/*  Write a program to find all increasing sequences inside an array of integers. 
    The integers are given on a single line, separated by a space. 
    Print the sequences in the order of their appearance in the input array, each at a single line. 
    Separate the sequence elements by a space. 
    Find also the longest increasing sequence and print it at the last line. 
    If several sequences have the same longest length, print the left-most of them.
*/
using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> longSequ = new List<int>();

        while (numbers.Count > 0)
        {
            // 2 3 4 1 50 2 3 4 5
            //  1 2 3 4 5 6 7 8 9
            List<int> tempList = new List<int>();
            tempList.Add(numbers[0]);
            int sequCount = 1;
            for (int i = 1; i < numbers.Count;)
            {
                if (numbers[i] > tempList.Last())
                {
                    tempList.Add(numbers[i]);
                    i++;
                    sequCount++;
                }
                else
                {
                    break;
                }
            }
            numbers.RemoveRange(0, sequCount);            
            if (tempList.Count > longSequ.Count)
            {
                longSequ = tempList;
            }
            Console.WriteLine(string.Join(" ", tempList));
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longSequ));
    }
}
