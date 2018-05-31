using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Crcle_and_Square_app
{
    class Square
    {
        //----------------Properties----------------

        public int XLocation { get; set; }

        public int YLocation { get; set; }

        public string SquareColor { get; set; }

        private int squareSide;

        public int SquareSide
        {
            get { return squareSide; }
            set { squareSide = Math.Abs(value); }
        }


        //--------------Constructor-----------------

        public Square(int xLocation, int yLocation, string squareColor, int squareSide)
        {

            XLocation = xLocation;
            YLocation = yLocation;
            SquareColor = squareColor;
            SquareSide = squareSide;


            Console.WriteLine("a new square was created");

        }

        //--------------Functions-------------------

        public string ShowSquareDetails()
        {
            return ($"x location is: {XLocation}, y location is: {YLocation}, square color: {SquareColor}, square side lingth: {SquareSide}.");
        }


        public int CalcSquareArea()
        {
            return (SquareSide * SquareSide);
        }

        public int SquarePerimeter()
        {
            return (SquareSide*4);
        }
    }
}
