using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding_2
{
    class employee
    {
        public string firstName;
        public string lastName;
        public void PrintFullName()
        {
            Console.WriteLine(firstName + "" + lastName);
            Console.WriteLine("Emir" + "Sarafoglu");
        }
    }
    class PartTimeEmployee : employee
    {
        /* The PrintfullName() method is declared with the new keyword, which hides the PrintfullName() method of the base class employee. 
         * When an instance of PartTimeEmployee is created and the PrintfullName() method is called, the new method in the derived class is executed, rather than the original method in the base class.*/
        public new void PrintFullName()
        {
            base.PrintFullName(); 
            //Console.WriteLine(firstName + "" + lastName + " PTE");
            Console.WriteLine("Krutika" + "Chauhan");
        }

    }

    /*
     In the FullTimeEmployee class, the PrintfullName() method is also declared with the new keyword, which hides the PrintfullName() method of the base class employee. 
    However, in this implementation, there is no call to the base class method, so only the output of the new method in the derived class will be displayed.
     */
    class FullTimeEmployee : employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(firstName + "" + lastName + " PTE");
            Console.WriteLine("Krutika" + "Chauhan");
        }
    }
    class program
    { 
    static void Main(string[] args)
    {
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.firstName = "krutika";
        PTE.lastName = "Chauhan";
        PTE.PrintFullName();
        Console.ReadLine();
    }
}
}
