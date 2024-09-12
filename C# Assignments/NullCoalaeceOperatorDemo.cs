using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 1. The ?? operator is also known as the null-coalescing operator.
   2. It returns the left side operand if the operand is not null else it returns the right side operand. 
   3. Coalescing operator returns the first non null value from the chain. 
*/

namespace NullCoaLaeceOperatorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit1 = "Apple";
            
            //string fruit1 = null;          // If the value is null then the next non null value is shown in the output i.e Banana
            string fruit2 = "Banana";
            string fruit3 = "Mango";

            string result = fruit1 ?? fruit2 ?? fruit3;
            Console.WriteLine(result);


            //string name = null;

            //// Instead of writing the if block we just need to use the null colaece operator
            //string result = name ?? "Anonymous";
            //Console.WriteLine(result);


            //if (name != null)
            //{
            //    result = name;
            //    Console.WriteLine(result);
            //}
            Console.ReadLine();
        }
    }
}
