/*
2.Remove Elements from a List: Write a method that removes a specific element from a list of strings.
*/
using System;
using System.Collections.Generic;

public class Program
{
    public static void RemoveElement(List<string> list, string element)
    {
        // Remove the element from the list
        list.Remove(element);

        // Print the elements
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static void Main(string[] args)
    {
        List <string> Fruits = new List<string> { "apple", "banana", "cherry", "Pineapple" , "Pomogranate"};
        string elementToRemove = "banana";

        RemoveElement(Fruits, elementToRemove);
    }
}