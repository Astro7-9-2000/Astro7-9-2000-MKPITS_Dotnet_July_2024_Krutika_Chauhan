/*
Add Elements to a List: Write a method that adds a list of integers (e.g., 1, 2, 3, 4, 5) to a List<int> and prints them.
*/
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List <int>();
        
        // Add elements to the list
        Numbers.Add(1);
        Numbers.Add(2);
        Numbers.Add(3);
        Numbers.Add(4);
        Numbers.Add(5);

        // Print the list
        Console.WriteLine("List elements:");
        foreach (int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }
}