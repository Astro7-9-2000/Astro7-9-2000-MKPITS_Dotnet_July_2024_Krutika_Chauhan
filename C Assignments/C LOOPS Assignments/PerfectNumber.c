#include <stdio.h>

int main() {
    int num, sum = 0, k;

    // User input
    printf("Input the number: ");
    scanf("%d", &num);

    printf("The positive divisors: ");
    for (k = 1; k < num; k++) {
        if (num % k == 0) {
            printf("%d ", k);
            sum += k;
        }
    }
    printf("\nThe sum of the divisors is: %d\n", sum);

    if (sum == num) {
        printf("So, the number is perfect.\n");
    } else {
        printf("So, the number is not perfect.\n");
    }

    return 0;
}