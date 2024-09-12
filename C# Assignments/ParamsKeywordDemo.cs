using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1.Params is an important keyword in C#.
2.It is used as a parameter which can take the variable number of arguments.
3.It is useful when programmer don,t have any prior knowledge about the number of parameters to be used.
4.The length of params will be zero if no arguments are passed.
5.Only one Params keyword is allowed and no additional Params will be allowed in function declaration after a params keyword.
6.Params should always be last parameter.
*/
namespace Params_Demo
{
    internal class Program
    {
        public static int add(params int[] nums)
        //public static int add(int a , int b)
        {
            int sum = 0;
            foreach (int i in nums)
            {
                sum = sum + i;
            }

            return sum;

            //int sum = a + b;
            //return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(10 , 20 , 30 , 40));
            Console.ReadLine();
        }
    }
}
