//10.Append Characters to a String: Write a method that uses StringBuilder to append multiple characters or strings to a base string.

using System;
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Happy ");
sb.AppendLine("Birthday");
Console.WriteLine(sb);
