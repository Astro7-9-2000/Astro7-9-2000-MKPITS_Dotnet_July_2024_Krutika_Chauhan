// 10. Develop a program that categorizes a given angle as acute, right, obtuse, or straight based on its measure using if statements

using System;

class Program
{
    static void Main()
    {
    Console.Write("Enter the angle measure in degrees: ");
    int angleMeasure = Convert.ToInt32(Console.ReadLine());
    
    // Calculate according to the angle
    if(angleMeasure < 0 || angleMeasure > 180)
    {
        Console.WriteLine("Invalid Angle . Please enter the number between 0 to 180");
    }
    else if(angleMeasure == 0 || angleMeasure == 180)
    {
        Console.WriteLine("The angle is straight.");
    }
    
    else if(angleMeasure == 90)
    {
        Console.WriteLine("The angle is Right.");
    }
    else if(angleMeasure > 90)
    {
        Console.WriteLine("The angle is Obtuse.");
    }
    else
    {
        Console.WriteLine("The angle is Acute.");
    }
}
}