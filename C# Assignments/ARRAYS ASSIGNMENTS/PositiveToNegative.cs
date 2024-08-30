using System;

class PositiveToNegative
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            int negativeNumber = -number;
            Console.WriteLine("The negative equivalent is: " + negativeNumber);
        }
        else
        {
            Console.WriteLine("You did not enter a positive number.");
        }
    }
}