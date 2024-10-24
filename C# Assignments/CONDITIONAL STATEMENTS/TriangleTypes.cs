// 1. Write a program that determines the type of a given triangle (equilateral, isosceles, or scalene) based on its side lengths using if statements.

using System;

class Program
{
    static void Main()
    {
        // User Input
        Console.Write("Enter the length of side A: ");
        int sideA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of side B: ");
        int sideB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of side C: ");
        int sideC = Convert.ToInt32(Console.ReadLine());

        // Conditions for Triangles
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive number.");
        }
        else if (sideA == sideB && sideB == sideC)
        {
            Console.WriteLine("The Triangle is equilateral.");
        }
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
        {
            Console.WriteLine("The Triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The Triangle is scalene.");
        }
    }
}