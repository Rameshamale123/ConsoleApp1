using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4       //calculate the area of triangle from user input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("base of triangle is ");
             double Base  = double.Parse(Console.ReadLine());
            Console.WriteLine("height of triangle is ");
            double height =double.Parse(Console.ReadLine());
            double area = 0.5* Base * height;
            Console.WriteLine("area of triangle is" + area);
            

        }
    }
}
