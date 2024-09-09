/*Write a C# program to convert a binary number into a decimal number using the math function. 
Test Data : 
Input the binary number :1010100 
Expected Output : The Binary Number : 1010100 
The equivalent Decimal Number is : 84*/

using System;

class BinaryToDecimalwithMathFunction
{
    static void Main(string[] args)
    {
        Console.Write("Input the binary number: ");
        string binaryNumber = Console.ReadLine();

        int decimalNumber = 0;
        int power = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            if (binaryNumber[i] == '1')
            {
                decimalNumber = decimalNumber + (int)Math.Pow(2, power);
            }
            power++;
        }

        Console.WriteLine("The Binary Number: " + binaryNumber);
        Console.WriteLine("The equivalent Decimal Number is: " + decimalNumber);
    }
}