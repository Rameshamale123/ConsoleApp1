using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Conditionalassignment1
{
    internal class Problem7
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char c = Convert.ToChar(Console.ReadLine());
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                Console.WriteLine(c + " is alphabate");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine(c + "is digit");
            }
            else
            {
                Console.WriteLine(c + "is a character");
            }

        }

    }
    class digit                              // it is three digit number or not if its 3 
    {                                             // print sum of 1st and 3 digit 
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a <= 999)
            {
                Console.WriteLine("it is three digit number");
                int first = a / 100;
                int last = a % 10;
                int sum = first + last;
                Console.WriteLine("sum of first and last digit is" + sum);
            }
            else
            {
                Console.WriteLine("it is not three digit number");

            }
                
           
           

        }
    }
    class Salary
    {
        static void Main(string[] args)
        {
            float basic, hra, da, gross;
            Console.WriteLine("enter the basic salary");
            basic = float.Parse(Console.ReadLine());
            if (basic <= 10000)
            {
                hra = basic * 0.2f;
                da = basic * 0.8f;
                gross = basic + hra + da;
                Console.WriteLine("gross salary is" + gross);
            }
            else if (basic <= 20000)
            {
                hra = basic * 0.25f;
                da = basic * 0.9f;
                gross= basic + hra + da;
                Console.WriteLine("gross salary is" + gross);
                
            }
            else if (basic > 20000)
            {
                hra = basic * 0.3f;
                da = basic * 0.95f;
                gross=basic + hra + da;
                Console.WriteLine("gross salary is" + gross);
            }
               
            
        }     

    }
    class wday
    {                                                 //switch case 
        static void Main(string[] args)
        {
            Console.WriteLine("enter the weekday no(0 to 6");
            int wday = Convert.ToInt32(Console.ReadLine());
            switch (wday)
            {
                case 0:
                    Console.WriteLine("it is a sunday");
                    break;
                case 1:
                    Console.WriteLine("it is monday");
                    break;
                case 2:
                    Console.WriteLine("it's tuesday");
                    break;
                case 3:
                    Console.WriteLine("it is wednesday");
                    break;
                case 4:
                    Console.WriteLine("it is thursday");
                    break;
                case 5:
                    Console.WriteLine("it is friday");
                    break;
                case 6:
                    Console.WriteLine("it is saturday");
                    break;

                    // if no case value is matched
                default:
                    Console.WriteLine("it is wrong input");
                    break;

            }

        }
    }
    class word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number (1 to 5)");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("IT's ONE");
                    break;
                case 2:
                    Console.WriteLine("IT'S TWO");
                    break;
                case 3:
                    Console.WriteLine(" ITS THREE");
                    break;
                case 4:
                    Console.WriteLine("IT'S FOUR");
                    break;
                case 5:
                    Console.WriteLine(" IT'S FIVE");
                    break;
                default :
                    Console.WriteLine("IT'S WRONG INPUT");
                    break;

            }
        }
       

    }
    class Day
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the weekday number (1 to 7)");
            int wday = int.Parse(Console.ReadLine());   
            switch(wday)
            {
                 case 1:
                    Console.WriteLine("it is monday");
                    break;
                 case 2:
                    Console.WriteLine("it is a tuesday");
                    break;
                case 3:
                    Console.WriteLine("it is wednesday");
                    break;
                case 4:
                    Console.WriteLine("it is thursday");
                    break;
                case 5:
                    Console.WriteLine(" it is a friday");
                    break;  
                case 6:
                    Console.WriteLine("it is a saturday");
                    break;
                case 7:
                    Console.WriteLine("it is sunday ");
                    break;
                default:
                    Console.WriteLine("invilid input");
                    break;
                    
   
            }
        }
    }
    class Oddeven1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            switch (num%2)
            {
                case 0:
                    Console.WriteLine("num is even ");
                    break;
                case 1:
                    Console.WriteLine("num is odd ");
                    break;
            
            }
              



        }
        class Add
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter the first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = int .Parse(Console.ReadLine());
                Console.WriteLine("1.Addition\n2.substraction\n3.multiplication\n4.division");
                Console.WriteLine("enter the choice");
                int choice = int.Parse(Console.ReadLine()); 
                switch(choice)
                {
                    case 1: Console.WriteLine("addition" + (num1+num2));
                        break;
                    case 2: Console.WriteLine("substraction" + (num1-num2));
                        break;
                    case 3: Console.WriteLine("multiplication" + (num1*num2));
                        break;
                    case 4: Console.WriteLine("division" + (num1 / num2));
                        break;
                    default: Console.WriteLine("invilid choice");
                            break;
                }
            }
        }
    
            
            

            
        



    }   
    class Opeartor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator\n+\n-\n*\n/");
            char ch = Convert.ToChar(Console.ReadLine());
             
            switch (ch)
            {
                case '+': Console.WriteLine("addition" + (num1 + num2));
                        break; 
                case '-': Console.WriteLine("substraction" + (num1 - num2));
                    break;
                case '*': Console.WriteLine("multiplication" + (num1*num2));
                    break;
                case '/': Console.WriteLine("division" + (num1/num2));
                    break;
                default: Console.WriteLine("invalid input ");
                    break;


            }


        }
    }
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            char ch = Convert.ToChar(Console.ReadLine());   
            switch(ch)
            {
                case 'a': Console.WriteLine("vowel");
                    break;
                case 'e': Console.WriteLine("vowel");
                    break;
                case 'i': Console.WriteLine("vowel");
                    break;
                case 'o': Console.WriteLine("vowel");
                    break;
                case 'u': Console.WriteLine("vowel");
                    break;
                case 'A': Console.WriteLine("vowel");
                    break;
                case 'E': Console.WriteLine("vowel");
                    break;
                case 'I': Console.WriteLine("vowel");
                    break;
                case 'O': Console.WriteLine("vowel");
                    break;
                case 'U': Console.WriteLine("vowel");
                    break;
                default: Console.WriteLine("consonent");
                    break;


            }
        }
    }
    class Simplecalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition\n2.Subtraction\n3.multiplication\n4.Division");
            Console.WriteLine("enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("addition" + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("substraction" + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("multiplication" + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("division" + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("invilid input");
                    break;
            }
        }
    }

        
}

