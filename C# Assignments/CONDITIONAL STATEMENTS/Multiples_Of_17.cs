// C# Program to Print all the Multiples of 17 which are Less than 100.
using System;

class Multiples_Of_17
{
    static void Main()
    {
        int k,int;
        Console.WriteLine("Multiples of 17 are : ");
        for (int = 1; int < 100; int++)
        {
            a = int % 17;
            if (a == 0)
            {
                Console.WriteLine(int);
            }
        }
        Console.ReadLine();
    }
}