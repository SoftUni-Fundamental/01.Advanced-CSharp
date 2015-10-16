/*  Write a program that reads from the console a number N and an array of integers given on a single line. 
    Your task is to find all subsets within the array which have a sum equal to N and print them on the console
    (the order of printing is not important). 
    * Find only the unique subsets by filtering out repeating numbers first. 
    * In case there aren't any subsets with the desired sum, print "No matching subsets."
*/

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        Console.Write("{0,-30}", "Enter number for subset sum:");
        int subSum = int.Parse(Console.ReadLine());

        Console.Write("{0,-30}", "Enter sub-set sequence:");
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(input);
        var unique = new HashSet<string>();
        
        bool noSubsets = true;
        int maskField = 1 << input.Length;
        for (int maskCount = 0; maskCount < maskField; maskCount++)
        {
            List<int> subSet = new List<int>();
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
                string setToString = string.Join(" + ", subSet) + " = " + subSum;
                unique.Add(setToString);
            }
        }
        if (noSubsets)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (var set in unique)
            {
                Console.WriteLine(set);
            }
        }
    }
}
