// C# program to check whether a triangle can be formed by the given angles

using System;

public class TraingleConditions
{
    static void Main()
    {
        int angle1 , angle2 , angle3 , sum;
        Console.Write("Enter angle1 of triangle: ");
        angle1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter angle2 of triangle: ");
        angle2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter angle3 of triangle: ");
        angle3 = Convert.ToInt32(Console.ReadLine());
        
        sum = angle1 + angle2 + angle3;
        
        if(sum == 180)
        {
            Console.Write("The triangle is valid.\n");
        }
        else
        {
            Console.Write("The triangle is Invalid.\n");
        }
    }
}