/*  Write a C program to make such a pattern as a pyramid with an asterisk.
 *
 * *
 * * *
 * * * *  */

#include <stdio.h>
int main()
{
    int rows, columns;

    for (rows = 1; rows <= 4; rows++){
        for (columns = 1; columns <= rows; columns++){
            printf("*");
        }
        printf("\n");
    }
}
