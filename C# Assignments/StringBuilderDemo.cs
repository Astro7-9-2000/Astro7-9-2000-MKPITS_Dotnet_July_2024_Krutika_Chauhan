using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// StringBuilder is a dynamic object that allows you to expand the number of characters in the string
// It doesn,t create a new object in the memory but dynamically expands memory to accommodate the modified string. 
// StringBuilder can be initialized the same way as class.

// You can give an initial capacity of characters by passing an int value in the constructor.

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!!");
            sb.Append("Krutika");
            sb.AppendLine("Chauhan");
            sb.Append("MCS");
            sb.Insert(5, "C#");
            sb.AppendFormat("{0:c}", 25);
            sb.AppendFormat("{0:x}", 25);
            sb.Remove(6, 5);
            sb.Replace("World", "C#");
            string s1 = sb.ToString(); // s1 will be immutable 
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}


// Append() and AppendLine() methods
/*
 1. The Append method of StringBuilder is used to add or append a string to StringBuilder.
 2. AppendLine() method appends the string with a newline at the end.
 */

// AppendFormat()
//1. Use AppendFormat method to format input string into specified format and then append it.


// Insert() Method
//1. The Insert() method inserts the string at specified index in stringBuilder.

// Remove() Method
// The Remove() method removes the string at specified index with specified length.

// Replace() Method
// The Replace() method replaces all occurrence of a specified string with a specified replacement string.

// ToString() String Builder
// Use ToString() method to get string from StringBuilder.

/************************** POINTS TO REMEMBER **************************/
/*
 * 1. StringBuilder is immutable
 * 2. StringBuilder performs faster than string when appending multiple string values.
 * 3. Use StringBuilder when you need to append more than three or 4 strings.
 * 4. The Append() and ToString() methods are available in the System.text namespace.