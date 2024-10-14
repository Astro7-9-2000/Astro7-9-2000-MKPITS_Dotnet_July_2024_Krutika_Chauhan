/*
25.Write a C program that displays the n terms of square natural numbers and their sum. 1 4 9 16 . n Terms Test Data : Input the number of terms : 5 Expected Output : The square natural upto 5 terms are :1 4 9 16 25 The Sum of Square Natural Number upto 5 terms = 55
*/
#include <stdio.h>

int main() {
    int n, k;
    int sum = 0;

    printf("Input the number of terms : ");
    scanf("%d", &n);

    printf("The square natural upto %d terms are : ", n);
    for (k = 1; k <= n; k++) {
        int square = k * k;
        printf("%d ", square);
        sum += square;
    }
    printf("\n");

    printf("The Sum of Square Natural Number upto %d terms = %d\n", n, sum);

    return 0;
}
