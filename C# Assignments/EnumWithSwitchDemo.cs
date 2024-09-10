using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWithSwitch
{
    internal class Program
    {
        enum Days
        {
            Sunday = 1, //0
            Monday = 2, //1
            Tuesday, //2
            Wednesday,//3
            Thursday,//4
            Friday, //5
            Saturday  //6
        }

        static void Main(string[] args)
        {
        //Days myDay = Days.Tuesday;
        int myDay = (int)Days.Monday;                 // TypeCasting
        switch (myDay)
            {
                case 1:
                    Console.WriteLine("Hello! This is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Hello! This is Monday");
                    break;
                case 3:
                    Console.WriteLine("Hello! This is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Hello! This is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Hello! This is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Hello! This is Friday");
                    break;
                case 7:
                    Console.WriteLine("Hello! This is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;

            }

            //switch (myDay)
            //{
            //    case Days.Sunday:
            //        Console.WriteLine("Hello! This is Sunday");
            //        break;
            //    case Days.Monday:
            //        Console.WriteLine("Hello! This is Monday");
            //        break;
            //    case Days.Tuesday:
            //        Console.WriteLine("Hello! This is Tuesday");
            //        break;
            //    case Days.Wednesday:
            //        Console.WriteLine("Hello! This is Wednesday");
            //        break;
            //    case Days.Thursday:
            //        Console.WriteLine("Hello! This is Thursday");
            //        break;
            //    case Days.Friday:
            //        Console.WriteLine("Hello! This is Friday");
            //        break;
            //    case Days.Saturday:
            //        Console.WriteLine("Hello! This is Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day");
            //        break;
                    
            //}
            Console.ReadLine();
        }
    }
    }

            
    

