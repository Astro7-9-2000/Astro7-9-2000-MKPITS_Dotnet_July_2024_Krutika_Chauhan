/*
5.Find the Maximum and Minimum in a List: Write a function to find the largest and smallest elements in a List<int>.
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void FindMaxMin(List<int> list)
    {
        // Initialize max and min with the first element of the list
        int max = list[0];
        int min = list[0];

       
        for (int k = 1; k < list.Count; k++)
        {
            if (list[k] > max)
            {
                max = list[k];
            }
            else if (list[k] < min)
            {
                min = list[k];
            }
        }

        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }

    public static void Main(string[] args)
    {
        List<int> myList = new List<int> { 5, 2, 8, 1, 9 };

        FindMaxMin(myList);
    }
}