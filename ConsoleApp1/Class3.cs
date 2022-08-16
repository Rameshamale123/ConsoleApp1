using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {//addition of two number 
            int a = 45;
            int b = 10;
            int sum = a + b;
            Console.WriteLine(sum);

            int diff = a - b;
            Console.WriteLine(diff);

            // cube of number
            int c = 8;
            int cube = c * c * c;
            Console.WriteLine("cube of number is" + cube);

            // code calculate area of rectangle
            int l = 6;
            int w = 4;
            int area = l * w;
            Console.WriteLine("area of rectangle is " + area);

        }



    }
    class Addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1" + " " + " enter num2");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("sum is" + sum);


        }



    }
    class Cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            int cube = a * a * a;
            Console.WriteLine("cube of number is " + cube);

        }


    }
    class Rectangle1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length");
            Console.WriteLine("enter the width");
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            int area = l * w;
            Console.WriteLine("area of rectangle is" + area);
        }
    }   }
   /* class Swap           //  swapping of two no without using third variable 
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 25;
            Console.WriteLine("value of a is" + a);
            Console.WriteLine(" value of b is " + b);
            a = a + b;
            b = b - a;
            a = a - b;
            Console.WriteLine("after swapping");
            Console.WriteLine("New value of a is" a);
        }*/
   




















     











