namespace ShapesDLL
{
    public class Rectangle : Shape, IDrawable
    {
        //-------------ctor----------------------
        public Rectangle(int xlocation, int ylocation, int length, int width): base (xlocation, ylocation)
        {
            Length = length;
            Width = width;

        }


        //---------------functions---------------
        public override int PerimeterCalc()
        {
           return (Length+Width)*2;
        }

        public override int SquareCalc()
        {
            return Length*Width;
        }

        public override string PrintInfo()
        {
            return $"the square is: {SquareCalc()}, and its perimeter is {PerimeterCalc()}. \n";
        }


        public string Draw()
        {
            string temp = "";

            for (int i=0; i< Width; i++)
            {
                for (int j=0; j< Length; j++)
                {
                    temp=temp+"*";
                }
                temp = temp + "\n";
            }

            return temp;
        }

        //--------------properties---------------

        public int Length { get; set; }
        public int Width { get; set; }
    }
}
