/* Write a C program to reverse the elements of a given array. */

// Header file
#include <stdio.h>

/* The reverse function takes three parameters:

arr: an array of integers
start: the starting index of the array
end: the ending index of the array */

void reverse(int arr[] , int start , int end)
{
    while (start < end)
    {
        // swap arr[start] & arr[end]
        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        start++;
        end--;
    }
}
/* The display function takes two parameters:

arr: an array of integers
len: the length of the array */

void display(int arr[], int len){
    
    for(int i = 0; i < len; i++)
        printf("%d ", arr[i]);
}

int main()
{
    // Array Declaration
    int arr[] = {10, 20, 30, 40, 50, 60};
    
    // Calculates the length of the array using sizeof(arr)/sizeof(arr[0]).
    /*sizeof(arr): This gives the total size of the array in bytes.
    sizeof(arr[0]): This gives the size of a single element in the array in bytes.*/
    
    int len = sizeof(arr)/sizeof(arr[0]);
    
    // Calling the reverse function passing the array with start index and end index is length - 1
    reverse(arr, 0, len-1);
    
    printf("Array in Reverse:\n");
    display(arr, len);

    return 0;
}

