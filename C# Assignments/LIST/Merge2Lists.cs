/* Merge Two Lists: Write a function that merges two lists of integers into a single list.
*/
using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> MergeLists(List<int> list1, List<int> list2)
    {
        // Create a new list to store the merged result
        List<int> mergedList = new List<int>();

        // Add all elements from list1 to the merged list
        mergedList.AddRange(list1);

        // Add all elements from list2 to the merged list
        mergedList.AddRange(list2);

        return mergedList;
    }

    public static void Main(string[] args)
    {
        List<int> list1 = new List<int> { 1, 2, 3 };
        List<int> list2 = new List<int> { 4, 5, 6 };

        List<int> mergedList = MergeLists(list1, list2);

        // Print the merged list
        foreach (var item in mergedList)
        {
            Console.WriteLine(item);
        }
    }
}