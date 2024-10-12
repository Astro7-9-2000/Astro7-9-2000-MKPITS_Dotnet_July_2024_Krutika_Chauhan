// 15.Convert StringBuilder to String: Write a function that takes a StringBuilder object and returns a string representation of it.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Happy , Birthday");
        
/* The ConvertStringBuilderToString function takes a StringBuilder object as input and returns a string representation of it using the ToString() method. 
This method is part of the StringBuilder class and returns a string that represents the current StringBuilder object.*/

        string str = ConvertStringBuilderToString(sb);
        Console.WriteLine(str);
    }
    
    static string ConvertStringBuilderToString(StringBuilder sb)
    {
        return sb.ToString();
    }
}