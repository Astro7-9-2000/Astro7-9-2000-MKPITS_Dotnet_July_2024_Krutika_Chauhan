// Write a C program to sort an array of integers in ascending order using the bubble sort algorithm.

#include <stdio.h>

int main()
{
    int array[100], n, count , d ,swap;

    printf("Enter the number of elements: ");
    scanf("%d", &n);

    printf("Enter %d integers\n", n);
    for (count = 0; count < n; count++)
        scanf("%d", &array[count]);

        for (count = 0; count < n - 1; count++)
        {
            for (d = 0; d < n - count - 1; d++)
            {
                if (array[d] > array[d + 1])
                {
                    swap = array[d];
                    array[d] = array[d + 1];
                    array[d + 1] = swap;
                }
            }
        }

    printf("Sorted Array: \n");

    for (count = 0; count < n; count++)
        printf("%d\n", array[count]);

    return 0;
}

