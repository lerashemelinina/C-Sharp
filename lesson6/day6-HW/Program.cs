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
            Building[] hotelsArray = new Building[5];
            hotelsArray[0] = new Hotel(200, true);
            hotelsArray[1] = new Hotel(300, true);
            hotelsArray[2] = new Hotel(20, false);
            hotelsArray[3] = new Hotel(35, false);
            hotelsArray[4] = new Hotel(100, true);

         
            foreach (Building hotel in hotelsArray)
            {
                Console.WriteLine(hotel.GetDetails());
            }

            Console.ReadKey();
        }
    }
}
