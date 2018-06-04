using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDLL
{
    public class Square : Shape, IDrawable
    {

        //--------------constructor------------

        public Square(int xlocation, int ylocation, int length):base(xlocation, ylocation)
        {
            Length = length;
        }

        //-------------functions--------------

        public override int PerimeterCalc()
        {
            return Length*4;
        }

        public override int SquareCalc()
        {
            return Length* Length;
        }

        public override string PrintInfo()
        {
            return  $"the square is:{SquareCalc()}, and its perimeter is: {PerimeterCalc()}. \n";
        }

      
            public string Draw()
            {
                string temp = "";

                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        temp = temp + "*";
                    }
                    temp = temp + "\n";
                }

                return temp;
            }
        

        //--------------properties-------------

        public int Length { get; set; }
    }
}
