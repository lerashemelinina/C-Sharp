using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"the sum of 5 and 7 is: {Calc.GetSub(5,7)}");
            Console.WriteLine($"the sum of 5, 7 and 12 is: {Calc.GetSub(5, 7,12)}");
            Console.WriteLine($"the sum of 5.4 and 7.2 is: {Calc.GetSub(5.4, 7.2)}");

            Console.ReadLine();
        }
    }
}
