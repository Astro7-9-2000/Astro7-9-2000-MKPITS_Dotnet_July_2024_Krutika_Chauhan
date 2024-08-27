/* Write a program in C to find the number and sum of all integers between 
100 and 200 which are divisible by 9.
 Expected Output :
Numbers between 100 and 200, divisible by 9 :
 108 117 126 135 144 153 162 171 180 189 198
 The sum : 1683 */ 

#include <stdio.h> // The standard input/output header file.

int main()
{
   int k, sum=0; // Declare variables for iteration and sum.

   printf("Numbers between 100 and 200, divisible by 9 : \n"); 

   for(k=101; k<200; k++) 
   {
     if(k % 9==0) 
     {
       printf("% 5d", k); 
       sum = sum +  k; // Add the number to the sum.
     }
   }

   printf("\n\nThe sum : %d \n", sum); 
}
