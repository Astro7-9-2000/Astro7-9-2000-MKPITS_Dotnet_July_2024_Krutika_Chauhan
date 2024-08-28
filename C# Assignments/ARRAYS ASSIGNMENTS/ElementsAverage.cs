// WAP to take array of integer as an input and return average of those numbers.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int[] numbers = new int[5];
        for (int k = 0; k<n; k++)
        {
            Console.Write("Enter element " +(k+1)+ ":");
            numbers[k] = Convert.ToInt32(Console.ReadLine());
        }
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        
        // Calculate the average
        float average = (float)sum / numbers.Length;
        
        Console.WriteLine("Average: " +average);
    }
}