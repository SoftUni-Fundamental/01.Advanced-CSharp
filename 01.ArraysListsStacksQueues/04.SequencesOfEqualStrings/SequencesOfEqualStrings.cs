/*  Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class SequencesOfEqualStrings
{
    static void Main()
    {
        List<string> strList = Console.ReadLine().Split(' ').ToList();

        while (strList.Count > 0)
        {
            string current = strList[0];
            for (int j = 0; j < strList.Count; j++)
            {
                if (current == strList[j])
                {
                    Console.Write("{0} ", strList[j]);
                }
            }
            Console.WriteLine();
            strList.RemoveAll(str => str == current);
        }
    }
}
