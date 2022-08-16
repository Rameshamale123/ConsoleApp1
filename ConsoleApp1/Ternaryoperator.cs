using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1  
{
    internal class Ternaryoperator   
    {
        static void Main(string[] args)        //number is positive or negative using ternary
        {
            Console.WriteLine( "enter the number");
            int num = int.Parse(Console.ReadLine());

            String result = num > 0 ? "positive" :"nagative";
            Console.WriteLine(result);
        }   
        

    }
    class Oddeven                                 // num is odd or even using ternery operator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());

            String result = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine(result);

               
        }
    }
    class Greater
    {
        static void Main(string[] args)                 //find greatest number between two
        {
            Console.WriteLine("enetr the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            // int result = num1>num2 ? num1 : num2;
            // Console.WriteLine(result);

            String result = num1 > num2 ? "num1 is greater" : "num 2 is greater";
            Console.WriteLine(result);
        }
    }
    class Greater1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            String result = num1 > num2 && num1 > num3 ? "num1 is greater" : num2 > num1 && num2 > num3 ? "num2 is greater " : "num3 is greater";
            Console.WriteLine(result);
        }
        
    }
    
                                        

}
