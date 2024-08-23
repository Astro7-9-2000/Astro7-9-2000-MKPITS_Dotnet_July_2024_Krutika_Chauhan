/* Write a program in C to read 10 numbers from the keyboard and find their sum and average.
Test Data :
Input the 10 numbers :
Number-1 :1
...
Number-10 :10
Expected Output :
The sum of 10 no is : 55
The Average is : 5.500000 */

#include <stdio.h>

int main()
{   
    int num, sum = 0;         // initializing sum to 0
    float avg;
    
    printf("Enter the 10 Numbers\n");
    for(int i = 1; i <= 10; i++)     // loop for user input
    {
        printf("Number %d = ", i);
        scanf("%d", &num);
        sum = sum + num;
    }

    avg = sum / 10;

    printf("\nThe Sum of 10 Numbers     = %d", sum); 
    printf("\nThe Average of 10 Numbers = %f\n", avg);
}

