/*
18. Write a program in C to find the sum of the series [ 1-X^2/2!+X^4/4!- 
Test Data :
 Input the Value of x :2
 Input the number of terms : 5
 Expected Output :
 the sum = -0.415873
 Number of terms = 5
 value of x = 2.000000
*/
#include <stdio.h>
#include <math.h>

int main() {
    int n, i;
    double x, sum = 1.0, term = 1.0, fact = 1.0;

    printf("Input the Value of x : ");
    scanf("%lf", &x);

    printf("Input the number of terms : ");
    scanf("%d", &n);

    for (i = 1; i < n; i++) {
        fact *= (2 * i) * (2 * i - 1);
        term = pow(-1, i) * pow(x, 2 * i) / fact;
        sum += term;
    }

    printf("The sum = %.6f\n", sum);
    printf("Number of terms = %d\n", n);
    printf("value of x = %.6f\n", x);

    return 0;
}
