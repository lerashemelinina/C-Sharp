namespace ShapesDLL
{
    public abstract class Shape
    {
        //------------------ctor----------------------

        public Shape(int xlocation, int ylocation)
        {
            XLocation = xlocation;
            YLocation = ylocation;
        }

        //------------------functions----------------

        public abstract int SquareCalc();

        public abstract int PerimeterCalc();

        public virtual string PrintInfo()
        {
            return $"x location is: {XLocation}, y location is: {YLocation}";
        }


        //------------------properties----------------

        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public string Color { get; set; }

    }
}

