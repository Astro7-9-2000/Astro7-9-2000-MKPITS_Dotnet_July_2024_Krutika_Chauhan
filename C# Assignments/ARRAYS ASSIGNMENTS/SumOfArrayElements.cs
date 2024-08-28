// Write a program to calculate sum of all the elements of an array

using System;
class Program
{
    static void Main()
    {
        int[] numbers = {1,2,3,4,5};
        
        // Initialize the sum variable to 0
        int sum = 0;
        
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        
        Console.WriteLine("Sum of Array elements: "  +sum);
    }
}
