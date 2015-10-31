/*  Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. 
    A sentence is any sequence of words ending with '.', '!' or '?'.

    This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)
*/

using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        Console.Write("Enter keyword:  ");
        string keyword = Console.ReadLine();
        Console.Write("Enter Text:  ");
        string text = Console.ReadLine();

        string pattern = @"((?<=\s|^)[A-Z](?:[A-Za-z\s\’\'\""\–\-]{1,}(?:[!.?])))";
        Regex regex = new Regex(pattern);
        
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            string sentence = match.ToString();
            string newPattern = "\\b(" + keyword + ")\\b";
            regex = new Regex(newPattern);

            if (Regex.IsMatch(sentence, newPattern))
            {
                Console.WriteLine(match);
            }
        }
    }
}
