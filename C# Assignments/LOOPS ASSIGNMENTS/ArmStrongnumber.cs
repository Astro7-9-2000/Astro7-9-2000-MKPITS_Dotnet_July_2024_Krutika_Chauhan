using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int sum = 0;
        int digitCount = num.ToString().Length;

        while (temp != 0)
        {
            int digit = temp % 10;
            int result = 1;
            for (int i = 0; i < digitCount; i++)
            {
                result *= digit;
            }
            sum += result;
            temp /= 10;
        }

        if (sum == num)
        {
            Console.WriteLine($"{num} is an Armstrong number");
        }
        else
        {
            Console.WriteLine($"{num} is not an Armstrong number");
        }
    }
}