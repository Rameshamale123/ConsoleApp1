using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Dowhile
    {
        static void Main(string[] args)
        {
            //initilization
            //do
            //{
            //logic 
            //increment /decrement
            //}  while (condition)

/*
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;    
            }  while (i > 0)*/;



            Console.WriteLine("enter the 1st number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2 nd number ");                // same no operATION PERFORM HOTIL
            int num2 = int.Parse(Console.ReadLine());

            char ch;
            do
            {
                Console.WriteLine("enter the choice");
                Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("invilid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue .......");
                ch = Convert.ToChar(Console.ReadLine());






            } while(ch=='y' || ch=='Y');    


        }
    }
    class Dowhile1
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter the 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the 2 nd number ");                // different number  no operATION PERFORM HOTIL
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the choice");
                Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
                int choice = int.Parse(Console.ReadLine());
               switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("invilid choice");
                        break;
                   
                }
                Console.WriteLine("Do you want to continue ......."); 
                ch = Convert.ToChar(Console.ReadLine());

            }   while(ch=='y' || ch=='Y');    

        }
}
}
