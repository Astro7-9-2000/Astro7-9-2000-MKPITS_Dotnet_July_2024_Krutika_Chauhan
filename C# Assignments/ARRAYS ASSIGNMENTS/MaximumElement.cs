// Write a C# program to find the maximum element in an array of integers.

using System;
class program
{
    static void Main()
    {
        int[] Array1 = {5,6,2,4,8};
        
        int max = Array1[0];
        
        for (int k = 1; k<Array1.Length; k++)
        {
            if (Array1[k] > max)
            {
                max = Array1[k];
            }
        }
        
        Console.WriteLine("The Maximum element is: " +max);
    }
}
