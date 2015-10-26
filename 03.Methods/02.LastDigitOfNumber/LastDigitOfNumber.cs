/*  Write a method that returns the last digit of a given integer as an English word.
    Test the method with different input values. Ensure you name the method properly.
*/

using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }

    static string GetLastDigitAsWord(int number)
    {
        string[] digitWords = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        int index = number % 10;
        return digitWords[index];
    }
}
