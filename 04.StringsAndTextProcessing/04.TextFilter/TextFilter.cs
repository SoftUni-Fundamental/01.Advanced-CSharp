/*  Write a program that takes a text and a string of banned words. 
    All words included in the ban list should be replaced with asterisks "*", equal to the word's length.
    The entries in the ban list will be separated by a comma and space ", ".
    The ban list should be entered on the first input line and the text on the second input line.
*/

using System;

class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        for (int i = 0; i < bannedWords.Length; i++)
        {
            while ((text.IndexOf(bannedWords[i], StringComparison.CurrentCultureIgnoreCase)) != -1)
            {
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
        }
        Console.WriteLine("Replaced:\r\n{0}", text);
    }
}
