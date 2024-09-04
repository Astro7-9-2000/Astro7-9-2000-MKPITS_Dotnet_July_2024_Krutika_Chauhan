 /* Write a program in C# to read 10 numbers from the  keyboard and find their 
sum and average.
 Test Data :
 Input the 10 numbers :
 Number-1 :2
 .
 Number-10 :2
 Expected Output :
 The sum of 10 no is : 55
 The Average is : 5.500000 */
 
 using System;
 
 class SumAndAverage
 {
     static void Main()
     {
         int sum = 0;
         float average = 0;
         
         Console.WriteLine("Input the 10 numbers: ");
         
         for (int k = 0; k<10; k++)
         {
             Console.WriteLine("Number: " +k + ": ");
             int num = Convert.ToInt32(Console.ReadLine());
             
             // Adding the current number to the sum
             sum = sum + num;
         }
         
         // Calculating Average
         average = sum / 10;
         Console.WriteLine("The sum of 10 numbers is: "+sum);
         Console.WriteLine("The Average is: " +average);
     }
 }
