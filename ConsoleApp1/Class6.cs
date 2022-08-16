using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int x = a++ + b++;
            Console.WriteLine(x + " " + a + " " + b); // 4 3 3   
            int y = --a + ++b + a;
            Console.WriteLine(y + " " + a +  " " + b); // 8 2 4    
            int z = a++ + --b - a;                         //
            Console.WriteLine(z + " " + a + " " +b); //2 3 3

             
        }
    }
}
