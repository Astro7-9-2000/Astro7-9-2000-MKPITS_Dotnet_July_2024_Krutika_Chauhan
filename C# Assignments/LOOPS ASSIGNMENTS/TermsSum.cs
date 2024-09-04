 /* Write a program in C# to display n terms of natural numbers and their sum.
 Test Data : 7
 Expected Output :
 The first 7 natural number is :
 1 2 3 4 5 6 7
The Sum of Natural Number upto 7 terms : 28 */

using System;
class TermsandSum
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        
        Console.Write("The first " +n+ "natural numbers are: ");
        for(int k = 1; k<=n; k++)
        {
            Console.Write(k + " ");
            sum = sum + k;
        }
        Console.WriteLine("\nThe Sum of Natural Number upto " +n+ " terms: " +sum);
    }
}

