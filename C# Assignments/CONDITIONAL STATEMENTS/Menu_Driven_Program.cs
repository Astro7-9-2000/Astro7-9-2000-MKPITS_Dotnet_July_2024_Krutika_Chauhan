// Menu driven program to perform simple calculations

using System;

public class Calculator
{
    static void Main()
    {
        int num1 , num2 , option;
        
        Console.Write("A menu driven program to build a simple calculator.");
        
        Console.Write("\nEnter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("\n Here are the options: ");
        Console.WriteLine("\n1 - Addition");
        Console.WriteLine("2 - Substraction");
        Console.WriteLine("3 - Multiplication");
        Console.WriteLine("4 - Division");
        Console.WriteLine("5 - Exit");
        Console.Write("\nEnter the choice: ");
        
        option = Convert.ToInt32(Console.ReadLine());
        
        
        switch (option)
        {
            case 1: 
            Console.Write("The Addition of {0} and {1} is: {2}\n" , num1 , num2 , num1 + num2);
            break;
            
            case 2:
            Console.Write("The Substraction of {0} and {1} is: {2}\n" , num1 , num2 , num1 - num2);
            break;
            
            case 3:
            Console.Write("The Multiplication of {0} and {1} is: {2}\n" , num1 , num2 , num1 * num2);
            break;
            
            case 4:
            if (num2 == 0)
            {
                Console.Write("The Division is not possible with zero.");
            }
            else
            {
                Console.Write("The Division of {0} and {1} is {2}\n" , num1 , num2 , num1 / num2);
            }
            break;
            case 5: 
            break;
            default: 
            Console.Write("Please enter correct option.\n");
            break;
        }
    }
}