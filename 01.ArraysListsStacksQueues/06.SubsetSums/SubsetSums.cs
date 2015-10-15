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
        //  0 11 1 10 5 6 3 4 7 2
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

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
            if (subSet.Sum() == 11)
            {
                Console.WriteLine("{0} = 11", string.Join(" + ", subSet));
            }
        }
    }
}
