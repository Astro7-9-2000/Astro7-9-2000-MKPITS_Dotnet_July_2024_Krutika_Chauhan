// BMI Calculator in C#

using System;

public class BMICalculator
{
    static void Main(string[] args)
    {
        // user input
        Console.Write("Enter your weight in kilograms (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your height in meters (m): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the BMI
        double bmi = weight / (height * height);

        Console.WriteLine("Your BMI is: " + bmi.ToString("F2")); 

        if (bmi < 18.5)
        {
            Console.WriteLine("Category: Underweight");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("Category: Normal weight");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("Category: Overweight");
        }
        else // bmi >= 30
        {
            Console.WriteLine("Category: Obesity");
        }
    }
}