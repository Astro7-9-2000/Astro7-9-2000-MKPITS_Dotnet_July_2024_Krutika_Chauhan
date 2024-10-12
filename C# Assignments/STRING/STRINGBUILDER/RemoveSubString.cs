//12.Remove Substring: Write a function that uses StringBuilder to remove a specified portion of a string (from index start to length).

using System;
using System.Text;

StringBuilder sb = new StringBuilder();

sb.Append("Happy ");
sb.AppendLine("Birthday");
sb.Remove(6, 7);
Console.WriteLine(sb);
