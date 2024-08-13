/*37. Write a program in C to display a given number in reverse order.
Test Data :
Input a number: 12345
Expected Output :
The number in reverse order is : 54321*/

#include<stdio.h>  
int main()    
{    
int num, reverse=0, rem;  

printf("Enter a number: ");    
scanf("%d", &num);    
while(num!=0)
{    
     rem=num %10;    
     reverse=reverse*10+rem;    
     num = num/10;    
}    
printf("Reversed Number: %d",reverse);    
return 0;  
}   