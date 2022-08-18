using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Sumofdigit
    {
        public int DigitSum(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            return sum;
        }
        static void Main(String[] args)
        {
            Sumofdigit s = new Sumofdigit();
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int result = s.DigitSum(num);
            Console.WriteLine("sum of digits =" + result);
        }

    }
   

    




   



    




               


              
            

        
        


            

           

    
}
