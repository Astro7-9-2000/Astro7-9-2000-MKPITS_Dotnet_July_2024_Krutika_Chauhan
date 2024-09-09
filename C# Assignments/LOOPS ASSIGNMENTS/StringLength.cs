/*
. Write a C program to find the length of a string without using the library 
function.
 Test Data :
 Input a string : welcome
 Expected Output :
 The string contains 7 number of characters.
 So, the length of the string welcome is : 7
*/

using System;

class StringLength
{
    static void Main(string[] args)
    {
        Console.Write("Input a string: ");
        string str = Console.ReadLine();
        
        int length = 0;
        
        foreach (char c in str)
        {
            length ++;
        }
        
        Console.WriteLine($"The string contains {length} number of characters: ");
        Console.WriteLine($"So , The length of the string {str} is: {length}");
    }
}