// C# Program to find the largest of 3 numbers

using System;

public class Largest
{
    static void Main()
    {
        int num1 , num2 , num3;
        Console.Write("Enter the first Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the third Number: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine("num1 is greatest" +num1);
        }
        else if (num2 >= num3 && num2 >= num3)
        {
            Console.WriteLine("num2 is greatest" +num2);
        }
        else
        {
        Console.WriteLine("num3 is greatest" +num3);
        }
    }
}