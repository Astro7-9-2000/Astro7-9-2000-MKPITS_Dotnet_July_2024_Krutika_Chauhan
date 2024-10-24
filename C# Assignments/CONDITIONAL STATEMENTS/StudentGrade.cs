// 3. Write a program in C# Sharp to accept a grade and declare the equivalent description 

using System;

public class Grade
{
    static void Main(string[] args)
    {
        char grade;
        string Status = "";
        
        Console.WriteLine("Enter the Grade: ");
        grade = Convert.ToChar(Console.ReadLine().ToUpper());
        
        // Applying Switch Case
        switch(grade)
        {
            case 'A':
                Status = "Excellent";
            break;
            case 'B':
                Status = "Very Good";
            break;
            case 'C':
                Status = "Good";
            break;
            case 'D':
                Status = "Poor";
            break;
            case 'E':
                Status = "Fail";
            break;
            default :
            Console.WriteLine("Invalid Grade!!");
            return;
        }
        Console.WriteLine("You have chosen : {0}", Status); 
    }
}