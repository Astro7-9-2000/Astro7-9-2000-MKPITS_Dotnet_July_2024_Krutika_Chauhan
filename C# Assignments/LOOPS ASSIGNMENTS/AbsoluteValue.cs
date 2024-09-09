// C# Program to Display Absolute value of a Number
// “Absolute value” means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).
 using System;
 
 class program
 {
     static void Main(string[] args)
     {
         int num;
         Console.Write("Enter a number: ");
         num = Convert.ToInt32(Console.ReadLine());
         if (num < 0)
         {
             num = num * -1;
         }
         
         Console.WriteLine("Absolute value: " +num);
         Console.ReadLine();
     }
 }