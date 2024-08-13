// C program to print V using *

#include <stdio.h>
int main()
{
    int lines;

    printf("Enter the number of lines: ");
    scanf("%d", &lines);
    for (int k = 1; k <= lines; k++)
    {
        for (int l = 1; l < (2 * lines) - 1; l++)
        {
            if ( l == k || l == (2 * lines) - k)
            {
                printf(" *");
            }
            else
            {
                printf(" ");
            }
        }
        printf("\n");
    }
    return 0;
}