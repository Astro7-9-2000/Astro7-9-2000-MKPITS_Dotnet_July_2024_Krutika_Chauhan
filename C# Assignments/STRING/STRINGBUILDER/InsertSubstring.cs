// 11.Insert Substring: Write a method that uses StringBuilder to insert a string at a specific position within an existing string.

using System;
using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Happy ");
sb.AppendLine("Birthday");
sb.Insert(7 , "Krutika");
Console.WriteLine(sb);
