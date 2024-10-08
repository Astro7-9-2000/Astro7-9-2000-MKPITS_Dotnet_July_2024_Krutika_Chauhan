/*
Remove Duplicates: Write a method that removes all duplicate characters from a string.
*/
using System;
using System.Linq;
using System.Collections.Generic;
   class Program {
      static void Main(string[] args) {
         string Str = "MMMKKKPPITSS";
         Console.WriteLine("Initial String: "+Str);
         
         // A HashSet<T> is a collection that stores unique elements, so this line effectively removes duplicates from the string.

         var unique_char = new HashSet<char>(Str);
         Console.Write("New String after removing duplicates: ");

         foreach (char c in unique_char) 
            Console.Write(c);   
      }
   }
