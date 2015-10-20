/*  
    Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
    You receive the layout of a board from the console.
    Assume it will always have 4 rows which you'll get as strings, each on a separate line. 
    Each character in the strings will represent a cell on the board. 
    Note that the strings may be of different length.

    You are the player and start at the top-left corner (that would be position [0, 0] on the board). 
    On the fifth line of input you'll receive a string with movement commands which tell you where to go next, 
    it will contain only these four characters: 
      '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 

    You need to keep track of two types of events – 
        collecting coins (represented by the symbol '$', of course) 
        and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). 
    When all moves are over, print the amount of money collected and the number of walls hit.
 
 */

using System;
using System.Linq;

class CollectTheCoins
{
    static void Main()
    {
        string[][] matrix = new string[4][];
        for (int row = 0; row < matrix.Length; row++)
        {
            string input = Console.ReadLine();
            matrix[row] = new string[input.Length];
            
            for (int col = 0; col < matrix[row].Length; col++)
			{
                matrix[row][col] = input[col].ToString();
/*
Sj0u$hbc
$87yihc87
Ewg3444
$4$$
V>>^^>>>VVV<<
*/
            }
        }
        //PrintMatrix(matrix);

        string commands = Console.ReadLine();
        int rows = 0, cols = 0;
        int wallHits = 0;
        int coins = 0;

        for (int i = 0; i < commands.Length; i++)
        {
            string ch = commands[i].ToString();
            if (matrix[rows][cols] == "$")
            {
                coins++;
            }
            bool field = false;
            if (ch == "V" || ch == "^")
            {
                int nextStep = Movements(ch);
                field = rows + nextStep >= 0 && rows + nextStep < 4 && matrix[rows + nextStep].Length > cols;
                if (field)
                {
                    rows += nextStep;
                }
                else
                {
                    wallHits++;
                }
            }
            else
            {
                int nextStep = Movements(ch);
                field = cols + nextStep >= 0 && cols + nextStep < matrix[rows].Length;
                if (field)
                {
                    cols += nextStep;
                }
                else
                {
                    wallHits++;
                }
            }
        }
        Console.WriteLine("Coins:      {0}", coins);
        Console.WriteLine("Wall Hits:  {0}", wallHits);
    }

    private static void PrintMatrix(string[][] matrix)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write("{0} ", matrix[row][col]);
            }
            Console.WriteLine();
        }
    }

    static int Movements(string step)
    {
        int moveValue = 0;
        switch (step)
        {
            case "V": moveValue = 1; break;
            case "^": moveValue = -1; break;
            case ">": moveValue = 1; break;
            case "<": moveValue = -1; break;
        }
        return moveValue;
    }
}