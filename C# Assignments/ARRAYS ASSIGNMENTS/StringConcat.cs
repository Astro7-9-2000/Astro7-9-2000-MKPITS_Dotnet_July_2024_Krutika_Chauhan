// C# Program to Copy a Section of One Array to Another

using System;

class Program
{
    static void Main()
    {
        
        // Define the Source Array
        int[] sourceArray = {1,2,3,4,5,6,7,8,9,10};
        
        // Define the destination Array
        int[] DestinationArray = new int[5];
        
        int startIndex = 3;
        int length = 5;
        for (int k = 0; k< length; k++)
        {
            DestinationArray[k] = sourceArray[startIndex + k];
        }
        
        // Print the DestinationArray
        Console.WriteLine("Destination Array: ");
        for (int k = 0; k<DestinationArray.Length; k++)
        {
            Console.Write(DestinationArray[k] + " ");
        }
    }
}



