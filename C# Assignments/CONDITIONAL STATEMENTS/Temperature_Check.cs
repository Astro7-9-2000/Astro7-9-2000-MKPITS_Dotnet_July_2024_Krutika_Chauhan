// C# program to read the temperature and display a suitable message

using System;

public class Temp_Check
{
    static void Main()
    {
    int temp;
    Console.Write("Enter the temperature: ");
    temp = Convert.ToInt32(Console.ReadLine());
    
    if(temp < 0)
        Console.WriteLine("Freezing weather.\n");
        else if (temp < 10)
        {
        Console.WriteLine("Very Cold weather.");
        }
        else if ((temp > 20) && (temp < 10))
        {
        Console.WriteLine("Cold Weather.");
        }
        else if((temp > 30) && (temp < 40))
        {
        Console.WriteLine("Normal in Temperature.");
        }
        else 
        {
        Console.WriteLine("Its very Hot");
        }
    }
}
