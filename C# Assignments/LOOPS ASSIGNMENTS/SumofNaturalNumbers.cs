 /* Write a C# program to compute the sum of the first 10 natural numbers.
 Expected Output :
 The first 10 natural number is :
 1 2 3 4 5 6 7 8 9 10
 The Sum is : 55 */
 
 using System;
 class Summation
 {
     static void Main()
     {
         int sum = 0;
         
         Console.Write("The first 10 natural numbers are: ");
         
         for(int k = 1; k<=10; k++)
         {
             Console.Write(k + " ");
             sum = sum + k;
         }
         Console.WriteLine("\nThe sum is:"  +sum);
     }
 }