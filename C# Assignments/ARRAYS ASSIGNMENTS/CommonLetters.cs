using System;

class CommonLetters
{
    static void Main(string[] args)
    {
        // User enters first string
        Console.Write("Enter the first string: ");
        string string1 = Console.ReadLine();

        // user enters second string
        Console.Write("Enter the second string: ");
        string string2 = Console.ReadLine();

        Console.WriteLine("Common letters: ");
        foreach (char c1 in string1) //  This loop iterates over each character c1 in string1
        {
            foreach (char c2 in string2) //  This loop iterates over each character c1 in string2
            {
                if (c1 == c2)
                {
                    Console.Write(c1 + " ");
                    break; 
                }
            }
        }
        Console.WriteLine();
    }
}