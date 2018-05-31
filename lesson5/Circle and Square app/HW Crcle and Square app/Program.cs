using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Crcle_and_Square_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter x location");
            int xLocation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter y location");
            int yLocation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter circle radius/square side length");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter color");
            string selectedColor = Console.ReadLine();

            Circle circle1 = new Circle(xLocation, yLocation, selectedColor, length);

            Console.WriteLine(circle1.ShowCircleDetails());
            Console.WriteLine($"circle area is: {circle1.CalcCircleArea()}");
            Console.WriteLine($"circle perimeter is: {circle1.CirclePerimeter()}");

            Console.WriteLine();
            Console.WriteLine();

            Square square1 = new Square(xLocation, yLocation, selectedColor, length);

            Console.WriteLine(square1.ShowSquareDetails());
            Console.WriteLine($"square area is: {square1.CalcSquareArea()}");
            Console.WriteLine($"square perimeter is: {square1.SquarePerimeter()}");

            Console.ReadKey();
        }
    }
}
