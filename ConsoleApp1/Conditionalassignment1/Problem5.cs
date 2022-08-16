using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                  Console.WriteLine(a + " is positive ");
              else if(a < 0)
                    Console.WriteLine(a + " is negative");
            else
                Console.WriteLine(a + " is zero"); 
           
            
             
             

        }
    }
   
    
            
    

}
    

