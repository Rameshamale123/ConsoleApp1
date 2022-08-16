using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");

            }


        }

        class Problem2
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the number ");
                int a = int.Parse(Console.ReadLine());
                if (a % 5 == 0 && a % 11 == 0)
                {
                    Console.WriteLine(a + " the num is divisible by 5 & 11");
                }
                else
                {
                    Console.WriteLine("the num is not divisible by 5 & 11");
                }

            }

        }
    }

}