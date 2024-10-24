// 2. Write a C# Sharp program to accept two integers and check whether they are equal or not.

using System;

public class EqualOrNot
{
    public static void Main()
    {
        int num1 , num2;
        Console.Write("Enter First NUmber: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter 2nd Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 ==  num2)
        Console.WriteLine("{0} and {1} are equal." , num1 , num2);
        else
        Console.WriteLine("{0} and {1} are not equal." , num1 , num2);
        
    }
}