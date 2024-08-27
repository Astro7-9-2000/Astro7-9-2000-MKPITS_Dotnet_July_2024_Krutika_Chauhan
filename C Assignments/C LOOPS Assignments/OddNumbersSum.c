/* Write a C program to display the n terms of odd natural numbers and their 
sum.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100 */

#include <stdio.h>
int  main()
{
int i,n,sum=0;
printf("Input the number of terms : ");
scanf("%d",&n);
printf("\nThe odd numbers are uptill the terms are :");
for(i=1;i<=n;i++)
{
printf("%d ",2*i-1);            // 2 * 5 - 1 = 10 - 1 = 9 i.e odd
sum+=2*i-1;
}
printf("\nThe Sum of odd Natural Number upto %d terms : %d \n",n,sum);
}
