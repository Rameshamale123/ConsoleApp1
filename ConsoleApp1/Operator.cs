using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Operator
    {
        static void Main(string[] args)
        {
            float a = 16.4f;
            int b = 12;
            float c;
            c = a * (b + a) / (a - b);
            Console.WriteLine("result is " + c);
        }
    }
    class Operator1
    {
        static void Main(string[] args)
        {
            int a, b, c, x;
            a = 90;
            b = 15;
            c = 3;
            x = a - b / 3 + c * 2 - 1;
            Console.WriteLine(x);
        }
    }
    class Operator3
    {
        static void Main(string[] args)
        {
            int a, b, c, x;
            a = 80;
            b = 15;
            c = 2;
            x = a - b / (3 * c) * (a + c);
            Console.WriteLine(x);
        }
    }
    class Operator4
    {
        static void Main(string[] args)
        {
            float cp = 15.0f;
            float profit = 20.0f;

            float sp = ((profit/ 100 ) * cp ) + cp;                                // (profit * cp) / 100 * (sp - cp)f;
            Console.WriteLine("selling price is " + sp);
        }
    }
    class Operator5
    {
        static void Main(string[] args)
        {
            float cp = 1.0f;
            float profit = 100.0f;

            float sp = ((profit / 100 ) * cp ) + cp;
            Console.WriteLine("selling price is"+ sp);
        }
    }
      
        
        
           
           
            
}





































































