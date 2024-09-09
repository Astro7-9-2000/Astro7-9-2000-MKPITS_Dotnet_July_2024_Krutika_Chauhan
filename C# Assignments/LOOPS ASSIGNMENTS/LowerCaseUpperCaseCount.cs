/*
 Write a C# program that takes input from the user and counts the number of uppercase and lowercase letters, as well as the number of other characters.
Test Data :
Input characters : w3resource
Expected Output :
Input characters: On Linux systems and OS X EOF is CTRL+D. For Windows 
EOF is CTRL+Z. Uppercase letters: 0 Lowercase letters: 9 Other characters: */

using System;
class CharacterCount
{
    static void Main(string[] args)
    {
        Console.Write("Input characters:");
        string input = Console.ReadLine();
        int upperCaseCount = 0;
        int lowerCaseCount = 0;
        int otherCount = 0;
        
        foreach (char c in input)
        {
            if (char.IsUpper(c))
            {
                upperCaseCount++;
            }
            else if (char.IsLower(c))
            {
                lowerCaseCount++;
            }
            else
            {
                otherCount++;
            }
        }
        
        Console.WriteLine($"UpperCase letters: {upperCaseCount}");
        Console.WriteLine($"LowerCase letters: {lowerCaseCount}");
        Console.WriteLine($"Other characters: {otherCount}");
    }
}