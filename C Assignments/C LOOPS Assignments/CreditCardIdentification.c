/*Most Credit cards are 15 or 16 digits. The first 6 digits indicate issuer number.
The next 5 refers to specific issuer bank.The final 6 equals the user account number
Card issuer          1st 6 digits     next 5 digits   Last 6 digits
MasterCard           starts with 5    2,3,4,5 or 6   Customer account number
Visa                 starts with 4    2-6            Customer account number
American Express     starts with 3    3,4,5          Customer account number*/

#include <stdlib.h>
#include <stdio.h>

int main()
{
    long digits, reEnterDigit, original;
    int total;
    int count1 = 0, count2 = 0;
    int num;
    int num_Array[16];

    void to_Exit()
    {
        printf("Exiting !.......\nThank You for Your Efforts !...\n");
    }

    void validate_Digits()
    {
        printf("\nEnter the Digits Again to find whether Number are Same:-\n");
        scanf("%ld", &reEnterDigit);

        if (original == reEnterDigit)
        {
            while (original != 0)
            {
                original = original / 10;
                count2++;
                if (count2 == 15)
                {
                    if (original == 5)
                    {
                        printf("Card is Master Card");
                    }
                    else if (original == 4)
                    {
                        printf("Card is Visa Card");
                    }
                    else if (original == 3)
                    {
                        printf("Card is American Express");
                    }
                    break;
                }
            }
        }
        else
        {
            printf("Digits Not Same !");
        }
    }

    void chk_Card_Name()
    {
        void validate_Digits();
        if ((num == digits) && (num = num_Array))
        {
            printf("\nEntered Number Correct !");
        }
        else
        {
            printf("\nEntered Number Not Correct \nPlease Correct the Numbers!");
        }
    }

    void check_Digits()
    {
        int option = 0;

        printf("Enter the 16 Digits of your Card Number:-\n");
        scanf("%lld", &digits);
        original = digits;

        while (digits != 0)
        {
            digits = digits / 10;
            count1++;
        }
        if (count1 == 16)
        {
            printf("You've Entered Total Sixteen Digits of Your Card Number !");
            validate_Digits();
        }
        else
        {
            printf("You Have Not Entered Total Sixteen Digits of Your Card Number  ! \n");
            printf("Please ''1' to Re-Enter OR Press '2' to Exit:- ");
            scanf("%d", &option);

            switch (option)
            {
            case 1:
                // clrscr();
                check_Digits();
                break;
            case 2:
                // clrscr();
                to_Exit();
                break;
            default:
                printf("Please Choose Valid Option !");
            }
        }
    }

    check_Digits();
}