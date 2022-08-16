using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7 // simple intrest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the principle amount");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the time");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the rate of intrest");
            int r = int.Parse(Console.ReadLine());
            int intrest = p * t * r / 100;
            Console.WriteLine("simple intrest is" + intrest);


        }
    }
    class Gain
    {
        static void Main(string[] args)
        {
            double cp = 27.50;
            double sp = 28.60;
            double gain = sp - cp;
            double percent  = (gain / cp) * 100;
            Console.WriteLine("gain in percent " + percent);


        }
        
       



    }
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the width ");
            int w = int.Parse(Console.ReadLine());
            int perimeter = 2 * (l + w);
            Console.WriteLine("perimeter of rectangle is" + perimeter);

               
            
        }
    }
    class Fahrenheit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temp in fahrenheit");     //c = (f - 32)*9/5
            double fahrenheit = int.Parse(Console.ReadLine());      //  = (f - 32)*1.8
            double celcius = (fahrenheit - 32) * 1.8;
            Console.WriteLine("temp in celciusis is" + celcius);         
                                                                         // f = (c*9/5)+32




        }
    }
    class Ret
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());    
            if (num>5)
            {
                Console.WriteLine("num is greater than five");
            }
            else
            {
                Console.WriteLine("num is not greater than five");
            }
        }
    }
    class Sat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1st number ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2 nd number");
            int num2 = int.Parse(Console.ReadLine()); 
            if (num1>num2)
            {
                Console.WriteLine("num1 is greater");
            }
            else
            {
                Console.WriteLine("num2 is greater");
            }
        }
    }
    class Teen
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "enter the age");
            int age = int.Parse(Console.ReadLine());
            if(age>=13 && age<=19)
            {
                Console.WriteLine("he is teenager");
            }
            else
            {
                Console.WriteLine("he is not teenager");
            }
        }
    }
    class Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num>0 && num<=9)
            {
                Console.WriteLine("num is single digit");
            }
            else if (num>=10 && num<=99)
            {
                Console.WriteLine("num is double digit");
            }
        }
    }
    class Age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your friend age");
            int friendage = int.Parse(Console.ReadLine());  
            if(friendage > myage )
            {
                Console.WriteLine("HI");
            }
            else if (myage>friendage)
            {
                Console.WriteLine("good morning");
            }
            else
            {
                Console.WriteLine("How are you");
            }
        }
    }
    class Multiple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");           //num is multiple of five or not 
            int num = int.Parse(Console.ReadLine());
            if(num%5==0)
            {
                Console.WriteLine("the num is multiple of five ");

            }
            else
            {
                Console.WriteLine("the num is not multiple of five");
            }
          

        }
    }
    class Day
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter day of week");
            string day = Console.ReadLine();
            Console.WriteLine( "1.monday\n2.tuesday\n3.wednesday\n4.thursday\n5.friday\n6.saturday\n7.sunday");
            Console.WriteLine("enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine(" monday is  weekday");
                    break;
                case 2: Console.WriteLine(" tuesday is weekday");
                    break;
                case 3: Console.WriteLine("weekday");
                    break;
                case 4: Console.WriteLine("weekday");
                    break;
                case 5: Console.WriteLine("weeday");
                    break;
                case 6: Console.WriteLine("weekend");
                    break;
                case 7: Console.WriteLine("weekend");
                    break;
            }

                
            





        }


    }
    
                
    

}














    
    


   
       
    

          
      
     


              
             