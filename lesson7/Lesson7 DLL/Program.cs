using System;
using ShapesDLL;

namespace Lesson7_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            string rectangleDraw;
            string squareDraw;
            int length;
            int width;
            int side;

            
            Console.WriteLine("please enter rectangle length");
            length = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter rectangle width");
            width = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(5, 6, length, width);
            rectangleDraw = rectangle1.Draw();
            Console.WriteLine(rectangle1.PrintInfo());
            Console.WriteLine(rectangleDraw);


            Console.WriteLine("please enter square side");
            side = Convert.ToInt32(Console.ReadLine());
            Square square1 = new Square(3, 7, side);
            Console.WriteLine(square1.PrintInfo());
            squareDraw = square1.Draw();
            Console.WriteLine(squareDraw);

            Console.ReadKey();

        }
    }
}
