/*
Write a C# program to convert a binary number into a decimal number 
without using array, function and while loop.
 Test Data :
 Input a binary number :1010101
 Expected Output :
 The Binary Number : 1010101
 The equivalent Decimal Number : 85
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a binary number: ");
        string binaryNum = Console.ReadLine();

        int decimalNum = Convert.ToInt32(binaryNum, 2);

        Console.WriteLine("The Binary Number: " + binaryNum);
        Console.WriteLine("The equivalent Decimal Number: " + decimalNum);
    }
}
