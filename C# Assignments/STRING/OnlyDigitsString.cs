/*
4.Check if a String Contains Only Digits: Write a method that checks if a string contains only numeric digits.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        bool isNumeric = IsNumeric(input);

        if (isNumeric)
        {
            Console.WriteLine("The string contains only numeric digits.");
        }
        else
        {
            Console.WriteLine("\nThe string contains non-numeric characters.");
        }
    }

  /* This method checks each character in the input string to see if it's a digit. If it finds       a single character that's not a digit, it returns false. If it checks all characters and they're all digits, it returns true.*/

    public static bool IsNumeric(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
