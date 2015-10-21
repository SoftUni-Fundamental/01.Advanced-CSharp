/*  Write a program that receives some info from the console about people and their phone numbers.
    You are free to choose the manner in which the data is entered; 
        each entry should have just one name and one number (both of them strings). 
    After filling this simple phonebook, upon receiving the command "search", 
    your program should be able to perform a search of a contact by name and print her details in format 
        "{name} -> {number}". 
    In case the contact isn't found, print 
        "Contact {name} does not exist."
 */

using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        
        while (true)
        {
            string[] input = Console.ReadLine().Split('-').ToArray();
            if (input[0] != "search" && input.Length > 1)
            {
                phonebook.Add(input[0], input[1]);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine();

        while (true)
        {
            string name = Console.ReadLine();
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine("{0} -> {1}", name, phonebook[name]);
            }
            else if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }
            else
            {
                break;
            }
            Console.WriteLine();
        }
    }
}
