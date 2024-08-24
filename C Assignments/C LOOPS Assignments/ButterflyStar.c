// C program to print a butterfly using stars
#include <stdio.h>

int main() 
{
    int outerloop, innerloop, rows, columns;

    printf("Enter the number of rows: ");
    scanf("%d", &rows);
    printf("Enter the number of columns: ");
    scanf("%d", &columns);

    for(outerloop = 1; outerloop <= rows; outerloop++) {
        for(innerloop = 1; innerloop <= columns; innerloop++) {
            if ((outerloop == 1) && (innerloop == 2 || innerloop == 3 || innerloop == 4)){
            printf("  ");
        }
        else if ((outerloop == 2) &&  (innerloop == 3)) {
            printf("  ");
        }
        else if ((outerloop == 3) && (innerloop == 2 || innerloop == 4)) {
            printf("  ");
        } 
        else if ((outerloop == 4) && (innerloop == 3 ))
        {
            printf("  ");
        }
        else if ((outerloop == 5) && (innerloop == 2 || innerloop == 3 || innerloop == 4)){
            printf("  ");
        }
        else
        {
            printf("* ");
        }
        }
        printf("\n");
    }
    return 0;
}
