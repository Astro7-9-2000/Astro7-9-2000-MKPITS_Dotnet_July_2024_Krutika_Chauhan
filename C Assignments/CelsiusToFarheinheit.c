// C program to convert Celsius to Farhenheit 
#include<stdio.h>

int main()
{
    float celsius, fahrenheit;
    printf("Enter temperature in Celsius: ");
    scanf("%f", &celsius);
    
    fahrenheit = (1.8*celsius) + 32;
    
    printf("Temperature in Fahrenheit is: %f ", fahrenheit);
    return 0;
}
