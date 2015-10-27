/*  Write a method which takes an array of any type and sorts it. 
    Use bubble sort or selection sort (your own implementation). 
    You may re-use your code from a previous homework and modify it. 
    Use a generic method (read in Internet about generic methods in C#). 
    Make sure that what you're trying to sort can be sorted – your method should work with numbers, strings, dates, etc., but not necessarily with custom classes like Student.
*/

using System;
using System.Collections.Generic;

class GenericArraySort
{
    static void Main()
    {
        List<int> ints = new List<int> { 1, 3, 4, 5, 1, 0, 5 };
        List<string> strings = new List<string> { "zaz", "cba", "baa", "azis" };
        List<DateTime> dates = new List<DateTime> { 
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1) };

        SortList(ints);
        SortList(strings);
        SortList(dates);
        Console.WriteLine(string.Join(", ", ints));
        Console.WriteLine(string.Join(", ", strings));
        Console.WriteLine(string.Join(", ", dates));
    }
    
    static void SortList<T>(List<T> list) where T : IComparable
    {
        for (int a = 0; a < list.Count - 1; a++)
        {
            int minValue = a;
            for (int b = a + 1; b < list.Count; b++)
            {
                if (list[minValue].CompareTo(list[b]) > 0)
                {
                    minValue = b;
                }
            }
            T temp = list[a];
            list[a] = list[minValue];
            list[minValue] = temp;
        }
    }
}
