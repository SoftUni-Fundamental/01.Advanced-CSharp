/*  Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
    Overload the methods to work with numbers of type double and decimal.
    Note: Do not use LINQ.  */

using System;

class NumberCalculations
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double[] doubleNumbers = Array.ConvertAll(input, n => double.Parse(n));
        decimal[] decimalNumbers = Array.ConvertAll(input, n => decimal.Parse(n));
        
        Console.WriteLine("\r\nMinValue: {0}\r\nMaxValue: {1}\r\nAverage: {2}\r\nSum: {3}\r\nProduct: {4}\r\n",
            GetMinValue(doubleNumbers), GetMaxValue(doubleNumbers), GetAverage(doubleNumbers), 
            GetSum(doubleNumbers), GetProduct(doubleNumbers));
        
        Console.WriteLine("\r\nMinValue: {0}\r\nMaxValue: {1}\r\nAverage: {2}\r\nSum: {3}\r\nProduct: {4}\r\n",
            GetMinValue(decimalNumbers), GetMaxValue(decimalNumbers), GetAverage(decimalNumbers),
            GetSum(decimalNumbers), GetProduct(decimalNumbers));
    }
    //  minimum
    static double GetMinValue(double[] numbers)
    {
        double minValue = double.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        return minValue;
    }
    static decimal GetMinValue(decimal[] numbers)
    {
        decimal minValue = decimal.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
        }
        return minValue;
    }
    //  maximum
    static double GetMaxValue(double[] numbers)
    {
        double maxValue = double.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }
        return maxValue;
    }
    static decimal GetMaxValue(decimal[] numbers)
    {
        decimal maxValue = decimal.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxValue)
            {
                maxValue = numbers[i];
            }
        }
        return maxValue;
    }
    //  average
    static double GetAverage(double[] numbers)
    {
        double average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        return (average / numbers.Length);
    }
    static decimal GetAverage(decimal[] numbers)
    {
        decimal average = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            average += numbers[i];
        }
        return (average / numbers.Length);
    }
    //  sum
    static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal GetSum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    //  product
    static double GetProduct(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    static decimal GetProduct(decimal[] numbers)
    {
        decimal product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}
