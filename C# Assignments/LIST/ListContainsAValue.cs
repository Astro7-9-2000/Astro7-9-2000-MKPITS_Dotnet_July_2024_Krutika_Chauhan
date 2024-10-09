/*
6.Check if a List Contains a Value: Write a method that checks if a list contains a specified value.
*/

using System.Collections.Generic;

public class Program
{
    public static bool ListContainsValue(List<int> list , int value)
    {
        foreach (int element in list)
        {
            if (element == value)
            {
                return true;
            }
        }
        return false;
    }
    
    public static void Main(string[] args)
    {
        List<int> list = new List<int> {1,2,3,4,5};
        int value = 0;
        
        if (ListContainsValue(list , value))
        {
            System.Console.WriteLine("The list contains the value " +value);
        }
        else
        {
            System.Console.WriteLine("The list does not contain the value"   +value);
        }
    }
}

