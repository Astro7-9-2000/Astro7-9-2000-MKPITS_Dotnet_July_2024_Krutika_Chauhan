// C# Program to Print Multiplication Table

using System;

class program
{
    static void Main()
    {
        int number = 5;
        
        Console.WriteLine("Multiplication Table of: " +number);
        for (int k = 1; k<=10; k++)
        {
            Console.WriteLine(number + " * " + k + " = " +number * k);
        }
    }
}
