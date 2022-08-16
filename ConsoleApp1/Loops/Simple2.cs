using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Simple2         // sum of number from 1 to that number 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");      
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)

            {
                sum = sum + i;
            }
               Console.WriteLine(sum);
            
        }
            
    }
    class Even            // 1 to 20 even number 
    {
        static void Main(string[] args)
        {
          for (int i=1;i<=20;i++)
          {
               if(i%2==0)
               {
                    Console.WriteLine(i);
               }
          }
                
                

                

        }
    }
    class Factor                 // factor of given number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }class Factor1                              // find factor of 10 
    {
        static void Main(string[] args)
        {
            int fact = 1;
            for (int i = 1;i<=4;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

        }
    }
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for (int i=2;i<num;i++)
            {
                if(num%i!=0)
                {
                  isprime = false;
                }
                else
                {
                    Console.WriteLine("prime");
                }
            }
            if (isprime == true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

        }
    }
    class Number
    {
        static void Main(string[] args)
        {
          for(int i=65;i<=78;i++)
          {
                Console.WriteLine(i);
          }
        }
    }
    class Odd                       //odd number between 15 to 35 
    {
        static void Main(string[] args)
        {
           for (int i=15;i<=35;i++)
           {
                if(i % 2!= 0) 
                {
                    Console.WriteLine(i);
                }
           }
         
        }
    }
    class Number2
    {
        static void Main(string[] args)
        {
            for ( int i=145;i>=115;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Sum
    {
        static void Main(string[] args)
        {   int oddsum = 0;    
          for(int i=0;i<=20;i++)
          {
                if (i%2!=0) 
                {
                    oddsum = oddsum + i;
                }
                
          }
            Console.WriteLine(oddsum);
        }
    }
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base number");
            int basenumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the exponent");
            int expo = int.Parse(Console.ReadLine());
            int power = 1;
            for(int i=1;i<=expo;i++)
            {
                power = power * basenumber;
            }
            Console.WriteLine(power);
        }
    }
    /*class Output
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 3;
            Console.WriteLine(a++ + b* ++c);
            Console.WriteLine("a=" +a+"b="+b +"c=" +c );
            Console.WriteLine(b*5/a+b++ +b);
            Console.WriteLine("a=" +a + "b" +b + "c" +c);
        }
    }
*/
            
}
