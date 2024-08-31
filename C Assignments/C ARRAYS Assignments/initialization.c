/*Write a C program to declare an array of 10 integers, initialize it with values from 1 to 10, 
and print these values.*/

#include <stdio.h>

int main() {

    // Array Declaration
    int arr[10]; 

    for(int i = 0; i < 10; i++) {
        arr[i] = i + 1;
    }

    // Print the values of the array
    for(int i = 0; i < 10; i++) {
        printf("arr[%d] = %d\n", i, arr[i]);
    }

    return 0;
}