using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string input = @"<ul>
 <li>
  <a href=""http://softuni.bg"">SoftUni</a>
 </li>
</ul>";
        string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
        string replacement = "[URL href=$1]$2[/URL]";
        Regex regex = new Regex(pattern);

        string output = Regex.Replace(input, pattern, replacement);
        Console.WriteLine(output);
    }
}
