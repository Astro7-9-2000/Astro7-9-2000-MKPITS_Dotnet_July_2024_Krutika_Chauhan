/* C# Program to calculate Acceleration */

using System;
class Program
{
    static void Main(string[] args)
    {
        int v , t , acc;
        Console.WriteLine("Enter the velocity : ");
         v = int.Parse(Console.ReadLine());
         
         Console.WriteLine("Enter the Time: ");
         t = int.Parse(Console.ReadLine());
         
         acc = v / t;
         Console.WriteLine("Acceleration : {0}" , acc);
    }
}