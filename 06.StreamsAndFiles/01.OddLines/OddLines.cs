/*  Write a program that reads a text file and prints on the console its odd lines. 
    Line numbers starts from 0.
    Use StreamReader.
*/

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        int counter = 0;
        string line;

        StreamReader file = new StreamReader("../../ten-lines.txt");
        try
        {
            while ((line = file.ReadLine()) != null)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
        }
        finally
        {
            file.Close();
        }       
    }
}
