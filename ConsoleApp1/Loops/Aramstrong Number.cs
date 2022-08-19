using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Aramstrongnumber
    {
        public bool IScheck(int num)                  // with return type with parameter  
        {
            int copynum = num;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                //  int c = r * r * r 
                // sum = sum + c;

                sum = sum + (r * r * r);
                num = num / 10;

            }
            if (copynum == sum)      
            {
                return true;    
            }
            else
            {
                return false;
            }
        }


        static void Main(string[] args)                         
        {
            Aramstrongnumber s = new Aramstrongnumber();
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            bool flag = s.IScheck(n);

            if (flag == true)
            {
                Console.WriteLine("Number is Aramstrong");
            }
            else
            {
                Console.WriteLine("Number is not Aramstrong");
            }

        }
    }



}   
