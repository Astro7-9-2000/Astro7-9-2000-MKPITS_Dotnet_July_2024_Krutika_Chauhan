using System;

public class Age_Check
{
    static void Main(string[] args)
    {
        // User Input
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();
        int age;
        
            // Attempt to convert the input to an integer
            age = Convert.ToInt32(input);

            // Check for negative age
            if (age < 0)
            {
                Console.WriteLine("Invalid input. Age cannot be negative.");
                return;
            }
        }

        // Determine the age group
        if (age >= 0 && age <= 12)
        {
            Console.WriteLine("You are a Child.");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a Teenager.");
        }
        else if (age >= 20 && age <= 64)
        {
            Console.WriteLine("You are an Adult.");
        }
        else // age >= 65
        {
            Console.WriteLine("You are a Senior.");
        }
    }
}