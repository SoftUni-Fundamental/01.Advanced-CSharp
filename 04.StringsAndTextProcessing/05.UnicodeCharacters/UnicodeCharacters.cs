/*  Write a program that converts a string to a sequence of C# Unicode character literals.
*/

using System;

class UnicodeCharacters
{
    static void Main()
    {
        string str = Console.ReadLine();
        foreach (var ch in str)
        {
            Console.Write("\\u{0:X4}", Convert.ToUInt32(ch));
        }
        Console.WriteLine();
    }
}
