/*  Modify the program you wrote for the previous problem to print the results in the following way: 
     * each line should contain the operands (numbers that form the desired sum) in ascending order; 
     * the lines containing fewer operands should be printed before those with more operands; 
     * when two lines have the same number of operands, the one containing the smallest operand should be printed first. 
     * If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSum
{
    static void Main()
    {
        Console.Write("{0,-30}", "Enter number for subset sum:");
        int subSum = int.Parse(Console.ReadLine());

        Console.Write("{0,-30}", "Enter sub-set sequence:");
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        var unique = new List<SortedSet<int>>();

        bool noSubsets = true;
        int maskField = 1 << input.Length;
        for (int maskCount = 0; maskCount < maskField; maskCount++)
        {
            var subSet = new SortedSet<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if ((maskCount & (1 << i)) > 0)
                {
                    subSet.Add(input[i]);
                }
            }
            if (subSet.Sum() == subSum && subSet.Count > 0)
            {
                noSubsets = false;
                unique.Add(subSet);
            }
        }

        unique.Sort((a, b) => (a.Count - b.Count));
        if (noSubsets)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (var set in unique)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ",set), subSum);
            }
        }
    }
}
