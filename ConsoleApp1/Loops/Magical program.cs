using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Magical_program
    {
        static void Main(string[] args)
        {
            int magicnum = 45;
            while(true)
            {
                Console.WriteLine("enter the number ");
                int num = int.Parse(Console.ReadLine());
                if (num > magicnum)
                {
                    Console.WriteLine("Number is greater try again.......");
                    continue;
                }
                else if (num < magicnum)
                {
                    Console.WriteLine("Number is less try again .....");
                    continue;
                }
                else
                {
                    Console.WriteLine("guess num is correct");
                    break;
                }

            }
        }
    }
}
