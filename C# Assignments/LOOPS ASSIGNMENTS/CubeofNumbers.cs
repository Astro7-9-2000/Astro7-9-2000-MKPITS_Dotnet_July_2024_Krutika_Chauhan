 /* Write a program in C# to display the cube of the number up to an integer.
 Test Data :
 Input number of terms : 5
 Expected Output :
 Number is : 1 and cube of the 1 is :1
Number is : 2 and cube of the 2 is :8
 Number is : 3 and cube of the 3 is :27
 Number is : 4 and cube of the 4 is :64
 Number is : 5 and cube of the 5 is :125 */
 using System;
 class Program
 {
    static void Main()
    {
        Console.Write("Input the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        for (int k = 0; k<n; k++)
        {
            // Calculating the cube
            int Cube = k * k * k;
            Console.WriteLine("Number is: " +k+ " and cube of " +k+ " is: " +Cube);
        }
    }
 }
