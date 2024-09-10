using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * BOXING 
 1.Implicit Conversion of a value type to a reference type is called Boxing.
 2.In Boxing process , a value type is being allocated on the heap rather than the Stack.
   The C# compiler converts the reference type variable into value type variable.
   Example -
   int num1 = 10;  // int is value type
   object obj1 = num1;  // Implicit conversion of value type into reference type.
 */

/*
 * UNBOXING 
 1. Explicit conversion of the same reference type (which is being created by Boxing) , Back to a value type.
    Example -
    int num1 = 10;  // int is value type
    object obj1 = num1;
    int num2 = (int)obj1;   // Explicit conversion of reference type into value type(Unboxing)
    
 2.In Unboxing process , An unboxed value is being allocated to a variable on the stack rather than the Heap.
 */
namespace BoxingUnboxingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;    // value type
            object obj1 = num1; // Implicit conversion from value type to reference type - Boxing

            int num2 = (int)obj1; // Explicit Conversion

        }
    }
}
