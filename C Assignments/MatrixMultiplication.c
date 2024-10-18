/*
 * C program to perform matrix multiplication 
 */
#include<stdio.h>    
int main()
{
    int row1,row2,col1,col2;
    printf("Enter number of rows for First Matrix:\n");    
    scanf("%d",&row1);    

    printf("Enter number of columns for First Matrix:\n");     
    scanf("%d",&col1); 

    printf("Enter number of rows for Second Matrix:\n");    
    scanf("%d",&row2); 
   
    printf("Enter number of columns for Second Matrix:\n");     
    scanf("%d",&col2);

    if(col1!=row2)
    {
        printf("Matrices Can't be multiplied together");
    }
    else
    {
        int m1[row1][col1],m2[row2][col2];
        printf("Enter first matrix elements \n");    
        for(int i=0;i<row1;i++)    
        {    
            for(int j=0;j<col1;j++)    
            {    
                scanf("%d",&m1[i][j]);    
            }    
        }    
        printf("Enter Second matrix elements\n");    
        for(int i=0;i<row2;i++)    
        {    
            for(int j=0;j<col2;j++)    
            {    
                scanf("%d",&m2[i][j]);    
            }    
        }    
        int mul[row1][col2];
        for(int i=0;i<row1;i++)    
        {    
            for(int j=0;j<col2;j++)    
            {    
                mul[i][j]=0; 
 
                // Multiplying i’th row with j’th column
                for(int k=0;k<col1;k++)    
                {    
                    mul[i][j]+=m1[i][k]*m2[k][j];    
                } 
            }    
        }    
        printf("Multiplied matrix\n");     
        for(int i=0;i<row1;i++)    
        {    
            for(int j=0;j<col2;j++)    
            {    
                printf("%d\t",mul[i][j]);    
            }    
            printf("\n");    
        } 
    }
    return 0;  
}