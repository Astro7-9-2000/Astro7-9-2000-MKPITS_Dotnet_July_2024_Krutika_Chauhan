using System;

class MergeArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in array1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[n1];
        for (int k = 0; k < n1; k++)
        {
            Console.Write("Enter element " + (k + 1) + " of array1: ");
            array1[k] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the number of elements in array2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int[] array2 = new int[n2];
        for (int k = 0; k < n2; k++)
        {
            Console.Write("Enter element " + (k + 1) + " of array2: ");
            array2[k] = Convert.ToInt32(Console.ReadLine());
        }

        int[] mergedArray = new int[array1.Length + array2.Length];
        int index = 0;

        for (int k = 0; k < array1.Length; k++)
        {
            mergedArray[index++] = array1[k];
        }

        for (int k = 0; k < array2.Length; k++)
        {
            mergedArray[index++] = array2[k];
        }

        Console.WriteLine("Merged array:");
        foreach (int element in mergedArray)
        {
            Console.Write(element + " ");
        }
    }
}