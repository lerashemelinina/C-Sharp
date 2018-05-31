using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    static class Calc
    {
        //------------properties--------------

        private static DateTime startDate;


        //------------constructor------------

        static Calc()
        {
            startDate = DateTime.Now;
            Console.WriteLine($"the time is {startDate} and you are using now calc app");
       
        }

        //--------------functions------------

        public static int GetSub(int a, int b)
        {
            return (a + b);
        }

        public static int GetSub(int a, int b,int c)
        {
            return (a + b + c);
        }

        public static double GetSub(double a, double b)
        {
            return (a + b);
        }
    }
}
