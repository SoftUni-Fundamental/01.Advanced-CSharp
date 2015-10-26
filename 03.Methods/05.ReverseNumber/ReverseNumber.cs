/*  Write a method that reverses the digits of a given floating-point number.
*/

using System;

class ReverseNumber
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        double reversed = double.Parse(ReverseCharArray(input));
        Console.WriteLine(reversed);
    }

    static string ReverseCharArray(char[] input)
    {
        string reveredArray = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reveredArray += input[i];
        }
        return reveredArray;
    }
}
