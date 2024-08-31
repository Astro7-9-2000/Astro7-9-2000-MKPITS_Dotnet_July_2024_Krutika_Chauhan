// Write a C program to merge two arrays into a single array.

/* Algorithm - Get the size of the two arrays and their respective elements from the user.
               Merge these arrays into a third array.
               Display the merged array.*/

#include <stdio.h>

int main()
{
    int a[50], b[50], merged[100], n1, n2, k;

    printf("Enter the size of 1st array: ");
    scanf("%d", &n1);
    printf("Enter the elements of 1st array: ");
    for (k = 0; k < n1; k++){
        scanf("%d", &a[k]);
    }

    printf("Enter the size of 2nd array: ");
    scanf("%d", &n2);
    printf("Enter the elements of 2nd array: ");
    for (k = 0; k < n2; k++){
        scanf("%d", &b[k]);
    }

    // Merging the two arrays.
    for(k = 0; k < n1; k++) {
        merged[k] = a[k];  
    }
    for(k = 0; k < n2; k++) {
        merged[n1+k] = b[k];  
    }

    for (k = 0; k < n1 + n2; k++){
        printf("%d ", merged[k]);
    }

    return 0;
}