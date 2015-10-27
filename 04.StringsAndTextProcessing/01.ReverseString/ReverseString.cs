/*  Write a program that reads a string from the console, reverses it and prints the result back at the console.
*/

using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string output = string.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            int index = (input.Length - 1) - i;
            output += input[index];
        }
        Console.WriteLine(output);
    }
}
