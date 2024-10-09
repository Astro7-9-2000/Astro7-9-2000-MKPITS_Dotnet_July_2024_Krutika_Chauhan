
/*
 * C# Program to Perfom Currency Conversions
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Choice :\n 1- Dollar to Rupee \n 2- Euro to Rupee \n 3- Pound to Rupee ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
        }

        switch (choice)
        {
            case 1:
                ConvertCurrency("Dollar", "Rupees", 1);
                break;
            case 2:
                ConvertCurrency("Euro", "Rupees", 2);
                break;
            case 3:
                ConvertCurrency("Pound", "Rupees", 3);
                break;
        }

        Console.ReadLine();
    }

    static void ConvertCurrency(string fromCurrency, string toCurrency, int choice)
    {
        Console.WriteLine($"Enter the {fromCurrency} Amount :");
        double amount;
        while (!double.TryParse(Console.ReadLine(), out amount) || amount < 0)
        {
            Console.WriteLine("Invalid amount. Please enter a non-negative number.");
        }

        Console.WriteLine($"Enter the {fromCurrency} Value (1 {fromCurrency} = ? {toCurrency}) :");
        double value;
        while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.WriteLine("Invalid value. Please enter a positive number.");
        }

        double result = amount * value;
        Console.WriteLine($"{amount} {fromCurrency} Equals {result} {toCurrency}");
    }
}