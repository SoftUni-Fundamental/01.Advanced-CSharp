/*  Write a program that reads some text from the console and counts the occurrences of each character in it. 
    Print the results in alphabetical (lexicographical) order.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> letters = new SortedDictionary<char, int>();
        foreach (var letter in input)
        {
            if (!letters.ContainsKey(letter))
            {
                letters.Add(letter, 1);
            }
            else
            {
                int value = letters[letter];
                letters[letter] = ++value;
            }
        }

        foreach (var ch in letters)
        {
            Console.WriteLine("{0}: {1} time/s", ch.Key, ch.Value);
        }
    }
}
