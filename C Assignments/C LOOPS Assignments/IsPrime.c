/* Write a C program to determine whether a given number is prime or not.
 Test Data :
 Input a number: 13
 Expected Output :
 13 is a prime number */

 //C Program to check whether a number is prime or not
#include <stdio.h>
int main() 
{
    int n;        
    printf("Input a number: ");
    scanf("%d",&n);    

    int count = 0;         
    for(int k = 2; k < n; k++)  //Check for factors
    {
        if(n % k == 0)
            count++;
    }
    if(count == 0)           
    {
        printf("%d is a prime number.", n);
    }
    else
    {
        printf("%d is not a prime number.", n);
    }
    return 0;
} 