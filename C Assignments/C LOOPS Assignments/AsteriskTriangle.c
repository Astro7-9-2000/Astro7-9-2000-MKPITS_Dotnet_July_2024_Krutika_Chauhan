/* Write a program in C to display a pattern like a right angle triangle using
an asterisk.
The pattern like :
*
**
***
****  */

#include <stdio.h>
int main()
{
    int outerloop, innerloop, rows;

    printf("Enter the number of rows: ");
    scanf("%d", &rows);

    for (outerloop = 1; outerloop <= rows; outerloop++){
        for (innerloop = 1; innerloop <= outerloop; innerloop++){
            printf("*");
        }
        printf("\n");
    }
}

