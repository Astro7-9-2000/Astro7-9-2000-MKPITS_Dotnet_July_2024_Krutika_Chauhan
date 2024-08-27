/* Que 2. Define a class to represent a bookshop Include the following members:
Data Member :- Name of Author-
               Name of Title - 
               Name of Price-
               Name  of Publisher -
               Member Functions- 
               To Assign Values - 
               To Display Value */

 using System;
 public class Book
 {
     // Data Members
     public string author;
     public string title;
     public decimal price;
     public string publisher;
     //Member functions
     public void values (string A , string T , decimal P , string p)  // functions with parameters 
     {
       author = A;
       title = T;
       price = P;
       publisher = p;
     }
     public void Showvalues()
     {
         Console.WriteLine("Book Details: ");
         Console.WriteLine("Author: " +author);
         Console.WriteLine("Title: " +title);
         Console.WriteLine("price: " +price);
         Console.WriteLine("publisher: " +publisher);
     }
     public static void Main(string[] args)
     {
// Creating object to assign values 
         Book obj = new Book();
         obj.values("Matthew Walker" , "Why We Sleep?" , 400m , "Allen Lane");
         obj.Showvalues();
     }
 } 
