using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 1. Enum is a set of Constants
 2. An enum is special "class" that represents a group of constants (unchangeable/read-only variable)
 3. Enum is short for "enumeration" , which means "specifically listed".
 4. To create an enum , use the enum keyword (instead of class or interface) and separate the Enum items with a comma.
 5. It makes constant values more readable , for example , WeekDays.Monday is more readable then number 0
    when referring to gthe day in a week.
 6. An enum is defined using the enum keyword , directly inside a namespace , class or structure.
    All the constant names can be declared inside the curly brackets and separeated by a comma.
 7. The default underlying type of an enum is int.
 8. The default value for first element is ZERO and gets incremented by 1.
 9. Enums are value types.
 10. Enums are more readable and maintainable.
11. Enum is converted into abstract class behind the scenes.

----------------------------------------------WHEN TO USE ENUMS------------------------------------------------
Enums are used when you have values that you know aren,t going to change , like month days , days , colors etc.

 */
namespace EnumerationDemo
{

    enum Days
    {
        Sunday = 1, //0
        Monday , //1
        Tuesday , //2
        Wednesday ,//3
        Thursday ,//4
        Friday , //5
        Saturday  //6
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = (int[])Enum.GetValues(typeof(Days));

            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            //string[] members = (string[])Enum.GetNames(typeof(Days));

            //foreach (string member in members)
            //{
            //    Console.WriteLine(member);
            //}


            //Console.WriteLine("Enter your Name");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your Day Sunday = 1 , Monday = 2, Tuesday = 3");
            //int value = int.Parse(Console.ReadLine());

            //Days myDay = (Days)value;
            //Console.WriteLine("My Name is: " + name + "  " +" And my Birth Day is: " +myDay);

            //int value = (int)Days.Saturday;
            //Console.WriteLine(value);

            //Days myDay = (Days)5;         // Explicit typecasting
            //Console.WriteLine(myDay);

            //Days birthDay = Days.Friday;
            //Console.WriteLine(birthDay);

            //Console.WriteLine(Days.Sunday);
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("My Name is Krutika Chauhan.");
            Console.ReadLine();
        }
    }
}


/*
 1. if values are not assigned to enum numbers ten the compiler will assign integer values to each member 
starting with zero by default.
 2. The first member of an enum will be 0 , and the value of each successive enum member is increased by 1.
 3. You can assign different values to enum member.
 4. Explicit casting is required to convert from an enum type to its underlying integral type.
 */
