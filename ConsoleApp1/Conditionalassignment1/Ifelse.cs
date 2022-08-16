using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Ifelse                         // num is divisible by 5 or not 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine("num is divisible by 5");
            }
            else
                Console.WriteLine("num is not divisible by 5");
        }
    }
    class Oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("num is even");
            }
            else
            {
                Console.WriteLine(" num is odd");
            }
        }
    }
    class Positivenegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is positive");
            }
            else
            {
                Console.WriteLine("num is negative");
            }
        }
    }
    class Name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("num is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("num is negative");
            }
            else
                Console.WriteLine("num is zero");
        }

    }
    class Alphabate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("enter character is alphabate");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("enter character is digit");
            }
            else
                Console.WriteLine("enter character is symbol");
        }

    }
    class Greater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }

        }
    }
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine("num is divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("num is not divisible by 3 and 9 ");
            }
        }

    }
    class Pass
    {
        static void Main(string[] args)
        {
        
            
                Console.WriteLine("enter the passing year");
                int yr = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the percentage");
                int per = int.Parse(Console.ReadLine());
                /*if (yr == 2022)
                {
                    if (per > 60)
                    {
                        Console.WriteLine("student is selected for the interview");
                    }
                    else
                    {
                        Console.WriteLine("year is corrt but per is less than 60");
                    }
                }
                else
                {
                    Console.WriteLine("student not selected");
                }*/
                if(yr==2022 && per>60)
                {
                     Console.WriteLine("student got selected");

                }
                else
                {
                     Console.WriteLine("student not selected");
                }

            


        }
    }
   
    
        
        
        
        
    
}

                   
                
          
                
                
                
                
               
        
                                                  
       
          
       
    
   
