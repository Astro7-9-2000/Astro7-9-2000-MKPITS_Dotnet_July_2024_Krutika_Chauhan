 /* Write a program in C# to make such a pattern like a right angle triangle 
with the number increased by 1.
 The pattern like :
 1
 2 3
 4 5 6
 7 8 9 10 */
 
 using System;
 
 class RightAngleTriangleNumbers
 {
     static void Main()
     {
         Console.Write("Enter the number of rows: ");
         int n = Convert.ToInt32(Console.ReadLine());
         
         int num = 1;
         
         for (int k = 1; k<=n; k++)
         {
             for(int l = 1; l<=k;  l++)
             {
                 Console.Write(num + " ");
                 num++;
             }
             
             Console.WriteLine();
         }
     }
 }
 
