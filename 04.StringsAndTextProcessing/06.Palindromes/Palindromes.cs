/*  Write a program that extracts from a given text all palindromes, 
    e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. 
    Use spaces, commas, dots, question marks and exclamation marks as word delimiters. 
    Print only unique palindromes, sorted lexicographically. 
    String comparison should be case-sensitive.
*/

using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        char[] separators = { ' ', '.', ',', '!', '?' };
        string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        SortedSet<string> unique = new SortedSet<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (IsPalindrome(input[i]))
            {
                unique.Add(input[i]);
            }
        }
        Console.WriteLine(string.Join(", ", unique));
    }

    static bool IsPalindrome(string word)
    {
        bool checker = false;
        if (word.Length == 1)
        {
            checker = true;
        }
        else
        {
            for (int i = 0; i < word.Length; i++)
            {
                int last = (word.Length - 1) - i;
                if (word[i] != word[last])
                {
                    break;
                }
                else if (i > last)
                {
                    checker = true;
                    break;
                }
            }
        }
        return checker;
    }
}
