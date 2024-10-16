// C program to demonstrate a runtime error

#include <stdio.h>
int main()
{
    int array[5];
    printf("%d" , array[10]);
    return 0;
}

// Throws a garbage value because we are trying to access the 10th element in the array