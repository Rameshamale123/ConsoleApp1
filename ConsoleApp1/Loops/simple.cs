using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Simple               //for(initilization,condition,ince/decrement)
    {
        static void Main(string[] args)
        {                                    
            int i; 
            for (i= 1;i<=5;i++)
            {
                Console.WriteLine("hello");
            }
        }
    }
    class Simple1
    {
        static void Main(string[] args)
        {
            for(int i= 1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Simple3
    {
        static void Main(string[] args)
        {
           for (int i = 15;i>=11;i--)
           {
                Console.WriteLine(i);
           }
        }
    }
    class Simple4
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<=6;i++)
            {
                Console.WriteLine("hii");
            }
        }
    }
    class Simple5
    {
        static void Main(string[] args)
        {
            for(int i = 1; ; i++)                  // infinite hii because no condition is given
            {
                Console.WriteLine("hii");
            }
        }
    }
    class Simple6
    {
        static void Main(string[] args)
        {
            for(int i = 1;i<=5;)                 // infinite 1 because no incre or decrement so
            {                                     // always true
                Console.WriteLine(i);
            }
        }
    }
    class Simple7
    {
        static void Main(string[] args)
        {
            for(; ; )                             // infinite hii 
            {
                Console.WriteLine("hii");
            }
        }
    }
}
