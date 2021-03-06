﻿/*  Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
*/

using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        var regex = new Regex(@"(\w)\1+");
        Console.WriteLine(regex.Replace(input, "$1"));
    }
}
