using System;

namespace Task2
{
    class Circle
    {
        private double radius;
        private double areaOfCircle;


        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
                AreaOfCircle = CalculateAreOfCircle();
            }
        }

        public double AreaOfCircle
        {
            get
            {
                return areaOfCircle;
            }

            set
            {
                areaOfCircle = value;
            }
        }
        public double CalculateAreOfCircle()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
