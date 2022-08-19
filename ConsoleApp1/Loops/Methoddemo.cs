using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    internal class Methoddemo
    {
        //AccessModifier return type method name(parameter list)
        //{
        //logic
        //}
        // no return type no parameter
        public void Show()//method defination
        {
            // method body
            Console.WriteLine("This is my method");

        }
        //no return type with parameter 
        public void Addition(float x,int y)
        {
            float ans = x + y;         
            Console.WriteLine(ans);
        }
        //with return type no parameter
        public double AreaCircle()
        {
            double area = 3.14 * 3 * 3;
            return area;    
        }
            //with return type with parameter
        public int Cubeofnumber(int num)
        {
            return (num * num * num);
        }

        static void Main(string[] args)
        {
            Methoddemo d = new Methoddemo();       //object defined 
            d.Show(); //method calling 
                      // d.Addition(6.7f, 3);
                      // from user 
            Console.WriteLine("enter the number in float");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int num2 = int.Parse(Console.ReadLine());

            d.Addition(num1,num2);

            double result = d.AreaCircle ();
            Console.WriteLine(result);

           // int cube = d.Cubeofnumber(3);
           // Console.WriteLine(cube);
            Console.WriteLine(d.Cubeofnumber(3));
        }
    }
}
