// C program to demonstrate a logical error

#include <stdio.h>

int main()
{
    int k ;
    for(k =0; k <= 5; k++);
    {
        printf("Hi Honey");
    }
    return 0;
}

// The loop iterates for 5 times but the output is shown only for 1 time because of a semicolon missing at the end of the for loop.