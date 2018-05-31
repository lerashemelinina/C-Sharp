using System;


namespace HW_Crcle_and_Square_app
{
    class Circle
    {
        //----------------Properties----------------

        public int XLocation { get; set; }

        public int YLocation { get; set; }

        public string CircleColor { get; set; }

        public const double Pi = 3.1410320;


        private int circleRadius;

        public int CircleRadius
        {
            get { return circleRadius; }
            set { circleRadius = Math.Abs(value);}
        }


        //--------------Constructor-----------------

        public Circle(int xLocation, int yLocation, string circleColor, int circleRadius)
        {

            XLocation = xLocation;
            YLocation = yLocation;
            CircleColor = circleColor;
            CircleRadius = circleRadius;
        

            Console.WriteLine("a new circle was created");

        }

        //--------------Functions-------------------

        public string ShowCircleDetails()
        {
            return ($"x location is: {XLocation}, y location is: {YLocation}, circle color: {CircleColor}, circle radius: {CircleRadius}.");
        }


        public double CalcCircleArea()
        {
            return (Pi * Math.Pow(CircleRadius, 2));
        }

        public double CirclePerimeter()
        {
            return (2 * Pi * CircleRadius);
        }
    }
}
