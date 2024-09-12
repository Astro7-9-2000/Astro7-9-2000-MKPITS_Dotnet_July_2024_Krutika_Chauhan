using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 1. The static property is used to access and manipulate static fields of a class in a safe manner.
 2. The static property declared by using the static keyword.
 3. We cannot initialize instance fields within static property.
 4. The static property is accessed using the class name and thus belongs to the class and rather than 
    just an instance of the class.
 */
namespace StaticPropertyDemo
{
    class University
    {
        private static string UniversityName;
        private static string DepartmentName;

        public static string _Universityname
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You cannot enter null or empty value in University Name !!");
                }
                else
                {
                    UniversityName = value;
                }
                UniversityName = value;
            }

            get
            {
                return UniversityName;
            }
        }

        public static string _DepartmentName 
        { 
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You are not allowed to insert null or empty value in department Name");
                }
                else
                {
                    DepartmentName = value;
                }
            }
            get
            {
                return DepartmentName;
            }
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            //University._Universityname = "";
            University._Universityname = "RTMNU";
            University._DepartmentName = "Software Engineering";
            Console.WriteLine("University Department Name is : {0}" , University._DepartmentName);
            Console.WriteLine("University Name is: {0}" , University._Universityname);
            //University._Universityname = null;    // setting the value as null and set block will execute
            Console.ReadLine();
        }
    }
}
