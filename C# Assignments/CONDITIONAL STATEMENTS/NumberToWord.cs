// C# program to read any digit and display in word using Switch Case

using System;

public class NumberToWord
{
    static void Main()
    {
        int Inputdigit;
        
        Console.Write("Accepting the digit and display it in word.");
        
        Console.Write("\nEnter Digit(0-9) : ");
        Inputdigit = Convert.ToInt32(Console.ReadLine());
        
        switch(Inputdigit)
        {
            case 0:
            Console.Write("Zero\n");
            break;
            
            case 1:
            Console.Write("One\n");
            break;
            
            case 2:
            Console.Write("Two\n");
            break;
            
            case 3:
            Console.Write("Three\n");
            break;
            
            case 4:
            Console.Write("Four\n");
            break;
            
            case 5:
            Console.Write("Five");
            break;
            
            case 6:
            Console.Write("Six");
            break;
            
            case 7:
            Console.Write("Seven");
            break;
            
            case 8:
            Console.Write("Eight");
            break;
            
            case 9:
            Console.Write("Nine");
            break;
            
            default :
            Console.WriteLine("Please Enter number within the Range of 1 - 7: ");
            break;
            
        }
        
    }
}

