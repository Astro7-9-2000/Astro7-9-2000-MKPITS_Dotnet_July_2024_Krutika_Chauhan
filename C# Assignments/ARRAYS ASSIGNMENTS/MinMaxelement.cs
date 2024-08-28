// WAP to find Maximum and Minimum ELement in an Array.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int[] array1 = new int[size];
        
        Console.WriteLine("Enter the elements of the array: ");
        for (int k = 0; k< size; k++)
        {
            Console.Write("Elemnet {0}:  " , k + 1);
            array1[k] = Convert.ToInt32(Console.ReadLine());
        }
        
        int max = array1.Max();
        int min = array1.Min();
        
        Console.WriteLine("Maximum element: " +max);
        Console.WriteLine("Minimum element: " +min);
    }
}