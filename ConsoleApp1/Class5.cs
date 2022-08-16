using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the marathi mark");
            int marathi = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the english ");
            int eng = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the math mark");
            int math = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the hindi mark");
            int hindi = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the history mark");
            int his = int.Parse(Console.ReadLine());
            int total = 500; // max mark of suject 
            int percent = ((marathi + eng + math + hindi + his) * 100 / total);
            Console.WriteLine("percentage is" + percent);

        }
    }
}
