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

            Console.WriteLine("please enter a first char:");
            char a1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("please enter a second char:");
            char a2 = Convert.ToChar(Console.ReadLine());

            int dif = a1 - a2;

            Console.WriteLine($"{a1}-{a2}={dif}");

            Console.ReadKey();

        }
    }
}
