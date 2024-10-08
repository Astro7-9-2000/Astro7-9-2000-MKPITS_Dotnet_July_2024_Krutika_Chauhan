using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        public static string ReverseString(string input)
        {
            /*
             The ToCharArray() method is used here to convert the input string into an array of characters. 
             This is necessary because the Array.Reverse() method, which is used to reverse 
             the order of the characters, operates on arrays, not strings.
             */
            char[] inputString = input.ToCharArray();
            Array.Reverse(inputString);
            return new string(inputString);
        }

        static void Main(string[] args)
        {
            string input = "Krutika Chauhan";
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);
            Console.ReadLine();
        }
    }
}
