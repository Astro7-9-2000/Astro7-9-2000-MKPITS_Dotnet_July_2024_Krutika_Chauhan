/*
 * C# Program to Trim the Given String
 */
using System;

    class Program
    {
        static void Main(string[] args)
        {
            string myString = "    KHUSHI      ";
            System.Console.WriteLine("The String Before Trimming :" +  
                                     "(" + myString + ")");
            System.Console.WriteLine("The String After Trimming :" + 
                                     "(" + myString.Trim() + ")");
            Console.Read();
        }
    }
