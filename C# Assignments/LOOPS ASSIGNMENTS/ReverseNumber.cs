/* Write a program in C# to display a given number in reverse order.
 Test Data :
 Input a number: 12345
 Expected Output :
 The number in reverse order is : 54321*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int reversedNum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }

        Console.WriteLine("The number in reverse order is: " + reversedNum);
    }
}
