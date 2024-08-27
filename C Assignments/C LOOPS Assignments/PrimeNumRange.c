/* Write a program in C to find the prime numbers within a range of 
numbers.
Test Data :
Input starting number of range: 1
Input ending number of range : 50
Expected Output :
The prime number between 1 and 50 are :
2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 */

#include <stdio.h> //standard input/output header file.

int main(){
    int num , i ,counter , startno , endno; //num = number, loop counters, startnumber and endnumnber

    printf("Input starting number of range: "); // User input
    scanf("%d",&startno); 

    printf("Input ending number of range : "); // User input
    scanf("%d",&endno); 

    printf("The prime numbers between %d and %d are : \n",startno,endno); 

    for(num = startno; num <= endno; num++) 
    {
        counter = 0; // Initialize the counter.

        for(i = 2; i <= num/2; i++) // Loop through possible divisors.
        {
            if(num % i == 0) // If a divisor is found...
            {
                counter++; // ...increment the counter.
                break; // Exit the loop.
            }
        }

        if(counter == 0 && num != 1) // If no divisors were found and the number is not 1...
            printf("%d ",num); 
    }
    printf("\n");  
}
