// 5. Develop a program that checks if a given number is a perfect square using if statements.

using System;

class Program
{
    static void Main()
    {
        // User input
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Check if the number is a perfect square
        if (number < 0)
        {
            Console.WriteLine("Negative Numbers cannot be perfect squares.");
        }
        
        else
        {
            // Function to calculate the Square Root
            double sqrt = Math.Sqrt(number);
            
            // Check if the square root is an integer
            if (sqrt == Math.Floor(sqrt))
        {
            Console.WriteLine($"{number} is a perfect square.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect square.");
        }
        }
    }
}