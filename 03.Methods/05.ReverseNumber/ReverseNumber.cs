/*  Write a method that reverses the digits of a given floating-point number.
*/

using System;

class ReverseNumber
{
    static void Main()
    {
        double input = double.Parse(Console.ReadLine());
        char[] chArray = input.ToString().TrimStart('-').ToCharArray();
        double reversed = double.Parse(ReverseCharArray(chArray));
        if (input > 0)
        {
            Console.WriteLine(reversed);
        }
        else
        {
            Console.WriteLine(reversed * -1);
        }
    }

    static string ReverseCharArray(char[] chArray)
    {
        string reveredArray = string.Empty;
        for (int i = chArray.Length - 1; i >= 0; i--)
        {
            reveredArray += chArray[i];
        }
        return reveredArray;
    }
}
