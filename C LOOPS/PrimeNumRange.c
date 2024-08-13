/* 34. Write a program in C to find the prime numbers within a range of 
numbers.
 Test Data :
Input starting number of range: 1
 Input ending number of range : 50
 Expected Output :
 The prime number between 1 and 50 are :
 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 */

 #include <stdio.h>
 int main()
 {
     int num, k, count, start, end;

     printf("Input number to start range: ");
     scanf("%d", &start);
     printf("Input number to end range: ");
     scanf("%d", &end);

     for (num = start; num <= end; num++)
     {
         count = 0;
         for (k = 2; k <= num / 2; k++)
         {
            if (num % k == 0)
            printf("")
         }
     }
 }