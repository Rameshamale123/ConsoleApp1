using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Problem6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(a + "is Even number");
            else
                Console.WriteLine(a + " is odd number");
        }
    }
}
