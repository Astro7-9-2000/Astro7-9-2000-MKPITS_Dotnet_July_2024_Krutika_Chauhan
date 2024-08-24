/*15. Write a C program to calculate the factorial of a given number.
Test Data :
Input the number : 5
Expected Output :
The Factorial of 5 is: 120*/

#include<stdio.h>  
int main()    
{    
 int userinput , fact=1, number;    
printf("Input the number: ");    
scanf("%d",&number); 

    for(userinput = 1; userinput <= number; userinput++){    
      fact = fact * userinput;    
  }    
printf("The Factorial of %d is: %d" , number , fact);    
return 0;  
}   

