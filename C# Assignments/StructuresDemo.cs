/*
1.In case of a class "new" keyword is compulsory while creating the object/instance , on the other hand "new" is not compulsory while working with structures.
2.In case of structures , If you don,t specify new keyword and constructor then you have to explicitly initialize the field.
3.In Structure , If we dont create a constructor then a default constructor comes 
into place just like in classes
4. We cannot explicitly create a default constructor in structure because it is 
always predefined.
5.Classes support inheritance whereas Structures do not support Inheritance.
*/

using System;

struct Books {
   public string title;
   public string author;
   public string subject;
   public int book_id;
};  

public class StructureDemo {
   public static void Main(string[] args) {
      Books Book1;   //Declaring Book1 
      Books Book2;   // Declaring Book2

      /* Book 1 specification */
      Book1.title = "C Programming";
      Book1.author = "Dennis Ritche"; 
      Book1.subject = "C Programming";
      Book1.book_id = 6495;

      /* Book 2 specification */
      Book2.title = "Bhagvad Gita";
      Book2.author = "Maharshi Vedvyas";
      Book2.subject =  "Mythology";
      Book2.book_id = 6496;

      /* Printing Book1 info */
      Console.WriteLine( "Book 1 title : {0}", Book1.title);
      Console.WriteLine("Book 1 author : {0}", Book1.author);
      Console.WriteLine("Book 1 subject : {0}", Book1.subject);
      Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

      /* Printing Book2 info */
      Console.WriteLine("Book 2 title : {0}", Book2.title);
      Console.WriteLine("Book 2 author : {0}", Book2.author);
      Console.WriteLine("Book 2 subject : {0}", Book2.subject);
      Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);       

      Console.ReadLine();
   }
}