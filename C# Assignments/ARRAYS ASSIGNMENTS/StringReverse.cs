// WAP to print an Input String( take user input ) in Reverse Order.

using System;

class program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();
        
        Console.WriteLine("Reversed string: ");
        for (int k = s.Length - 1; k>=0; k--)
        {
            Console.Write(s[k]);
        }
        Console.WriteLine();
    }
}