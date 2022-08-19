using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Aramstrongnumber2
    {
        public void CheckAramstrong(int num)           // no return type with parameter    
        {
            int sum = 0;
            int copy = num;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r * r * r;
                num = num / 10;

            }
            if (sum == copy)
            {
                Console.WriteLine("Aramstrong");
            }
            else
            {
                Console.WriteLine("not Aramstrong");
            }
        }
        static void Main(string[] args)
        {
            Aramstrongnumber2 s = new Aramstrongnumber2();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            s.CheckAramstrong(num);
            
        }
        

    }
}
