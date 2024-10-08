/*
Find All Substrings: Write a function that prints all substrings of a given string.
*/
using System;
namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            
            int len = inputString.Length;
            Console.WriteLine("All substrings for given string are : ");
            
            //This loop maintains the starting character  
            for (int start_char = 0;  start_char< len; start_char++)
            {
                //This loop adds the next character 
                for (int next_char = 0; next_char < len - start_char; next_char++)
                {
                    Console.Write (inputString.Substring(start_char, next_char + 1) + " ");
                }
            }
            
            Console.ReadKey();
        }
    }
}
