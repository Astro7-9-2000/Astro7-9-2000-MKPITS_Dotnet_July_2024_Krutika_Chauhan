/* 13. Write a program in C to make a pyramid pattern with numbers increased 
by 1.
 1 
2 3 
4 5 6 
7 8 9 10 */


#include <stdio.h>

int main()
{
    int rows , k , l , num = 1;
    
    printf("Input the number of rows: ");
    scanf("%d" , &rows);
    
    for (k = 1; k<rows; k++) {
        for (l = 1; l<= k; l++) {
            printf("%d " , num);
            num++;
        }
        printf("\n");
    }
}

