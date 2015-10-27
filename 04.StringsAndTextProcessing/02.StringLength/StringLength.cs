﻿/*  Write a program that reads from the console a string of maximum 20 characters. 
    If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.
*/

using System;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = input.PadRight(20, '*').Substring(0, 20);
        Console.WriteLine(output);
    }
}
