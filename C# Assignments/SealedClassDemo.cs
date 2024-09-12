using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;


// A selaed class is a class that prevents Inheritance.
/* The features of a sealed class are as follows:
 1. A sealed class can be declared by preceding the class keyword with the sealed keyword.
 2. The sealed keyword prevents a class from being inherited by any other class.
 3. The sealed class cannot be a base class as it cannot be inherited by any other class. If a class tries to derive a sealed class , The C#
    compiler generates an error.
 */
namespace SealedClassDemo
{
    // This class cannot be inherited and hence cannot be base class.
    sealed class BaseClass
    {
        public void Show1()
        {
            Console.WriteLine("Method of Base class...");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Show2()
        {
            Console.WriteLine("Method of Derived class...");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.Show1();
            Console.ReadLine();
        }
    }
}


/* Real-time exaample - Consider a class named SystemInformation that consists of critical methods that affect 
 * the working of the operating system.
 * You might not want any third party to inherit the class SystemInformation and override its methods , thus causing security
 * and copyright issues.
 * Here you can declare the SystemInformation class as sealed to prevent any change in its variables and methods.*/