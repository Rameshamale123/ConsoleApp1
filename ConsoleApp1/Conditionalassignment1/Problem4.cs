using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            char c = Convert.ToChar(Console.ReadLine());
            if ((c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') || (c == 'A' || c == 'E' || c == 'I'
               || c == 'O' || c == 'U'))
            {  
                Console.WriteLine("Vowel");
            }
            else
                Console.WriteLine("consonent");
        }
    }
}
