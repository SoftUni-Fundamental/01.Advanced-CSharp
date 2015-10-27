/*  Write a program to find how many times a given string appears in a given text as substring. 
    The text is given at the first input line. 
    The search string is given at the second input line.
    The output is an integer number. 
    Please ignore the character casing.
    Overlapping between occurrences is allowed.
*/

using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine();
        string subStr = Console.ReadLine();

        int counter = 0;
        int i = 0;
        while ((i = input.IndexOf(subStr, i, StringComparison.CurrentCultureIgnoreCase)) != -1)
        {
            i++;
            counter++;
        }
        Console.WriteLine(counter);
    }
}
