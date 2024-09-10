using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Indexers allow our object to be used just like an array , or we can say we can index the object using [] brackets just like arrays.
1. We can say indexers are special type of properties which adds logic that how can array or list store the values.
2. Indexers are the regular members of a class 
3. Indexers is created with the help of this keyword 
4. All the access modifiers can be used with indexers and also have return types .
5. We provide the index to the object in indexer just like Array 
6. Indexers in c# must have atleast 1 parameter. Else the compiler will generate a compiler error. */
namespace IndexersDemo
{
    class Employee
    {
        private int[] Age = new int[3];

        public int this [int index]
        {
            set
            { 
                    if (index >= 0 && index < Age.Length)
                    {
                        if (value > 0)
                        {
                            Age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine("value is Invalid !!");
                        }
                    }
                else
                {
                    Console.WriteLine("Invalid Index !!");
                }
                }
            
            get 
            {
                return Age[index];
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp[2] = 5;                    // this [int index] - this = emp , 0 = index - set block will execute
            Console.WriteLine(emp[2]);   // get block will execute
            Console.ReadLine();
        }
    }
}
