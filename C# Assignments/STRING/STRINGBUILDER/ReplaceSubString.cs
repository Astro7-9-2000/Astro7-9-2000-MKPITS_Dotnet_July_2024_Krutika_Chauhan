//13. Replace Substring: Write a method that uses StringBuilder to replace all occurrences of a substring within a string.

using System;
using System.Text;

StringBuilder sb = new StringBuilder();

sb.Append("Happy ");
sb.AppendLine("Birthday");
sb.Replace("Birthday" , "19th Birthday");
Console.WriteLine(sb);
