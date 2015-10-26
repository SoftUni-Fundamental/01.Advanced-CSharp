/*  Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
*/

using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstNumber, secondNumber));
    }

    static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}
