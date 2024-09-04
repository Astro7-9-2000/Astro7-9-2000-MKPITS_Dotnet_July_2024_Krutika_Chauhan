 /* Write a program in C# to display a pattern like a right angle triangle using 
an asterisk.
 The pattern like :
 *
 **
 ***
 **** */
 
 using System;
 
 class RightAngleTriangle
 {
     static void Main()
     {
         Console.Write("Enter the number of rows; ");
         int n = Convert.ToInt32(Console.ReadLine());
         
         for (int rows = 1; rows <= n; rows++)
         {
             for(int columns = 1; columns <= rows; columns++)
             {
                 Console.Write("*");
             }
             
             Console.WriteLine();
         }
     }
 }
