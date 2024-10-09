/*
7. Convert Array to List: Write a function that converts an array of integers to a list of integers.
*/

using System.Collections.Generic;

public class Program
{
    public static List<int> ConvertArrayToList(int[] Array)
    {
        List<int> list = new List<int>();
        foreach (int element in Array)
        {
            list.Add(element);
        }
        
        return list;
    }
    
    public static void Main(string[] args)
    {
        int[] Array = {1,2,3,4,5};
        List<int> list = ConvertArrayToList(Array);
        
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
    }
}