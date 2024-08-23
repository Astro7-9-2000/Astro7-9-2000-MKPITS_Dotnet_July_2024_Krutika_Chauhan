/*2. Write a C program to compute the sum of the first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55*/

#include <stdio.h>  //standard input/output header file.

int main() {  
    int counter, sum = 0;  // counter for the loop counter and sum to store the sum.

    printf("The first 10 natural numbers are :\n");  

    for (counter = 1; counter <= 10; counter++)  
    {
        sum = sum + counter;  
        printf("%d ", counter);  // Print the current value of 'counter'.
    }

    printf("\nThe Sum is : %d\n", sum);  
    return 0; 
}


