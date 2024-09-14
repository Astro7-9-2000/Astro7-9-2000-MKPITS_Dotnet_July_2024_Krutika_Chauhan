using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
1.Method hiding occurs in Inheritance relationship when base class and derived class both have a 
method with same name and same signature.
2. when we create the object of derived class it will hide the base class method and will call its 
own method and this is called method hiding or name hiding.
3.We use new keyword in derived function name to show that implementation of the 
function in derived class no longer want to use base class method.
4.Parent class can have the reference of its child class.
5.When we create the object of child class , parent class object is also created.
 */

namespace Method_Hiding_Demo
{
     class Parent
    {
        public void Show()
        {
            Console.WriteLine("Parent class Method");
        }
    }

    class Child : Parent
    {
        public new void Show()   // This hides the method of parent class
        {
            // By using the base keyword a hidden base class member from derived class can be called.
            base.Show();
            //Console.WriteLine("Child class Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.Show();
            Child c = new Child();
            //((Parent)c).Show();   // Typecasting 
            //c.Show();
            Console.ReadLine();
        }
    }
}
