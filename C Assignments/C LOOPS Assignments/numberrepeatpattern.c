/*11. Write a program in C to make such a pattern like a right angle triangle
with a number which will repeat a number in a row.
The pattern like :
1
22
333
4444*/

#include <stdio.h>
int main()
{
    int outerloop, innerloop , rows;

    printf("Enter the number of rows: ");
    scanf("%d", &rows);

    for (outerloop = 1; outerloop <= rows; outerloop++){
        for (innerloop = 1; innerloop <= outerloop; innerloop++){
            printf("%d" , outerloop);
        }
        printf("\n");
    }
}