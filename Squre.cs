using System;

namespace Task1
{
    class Squre
    {
        private double side;
        private double areaOfSquare;

        public Squre(double side)
        {
            Side = side;
        }

        public double Side
        {
            get
            {
                return side;
            }

            set
            {
                side = value;
                areaOfSquare = CalculateAreaOfSqure();
            }
        }

        public double AreaOfSquare
        {
            get
            {
                return areaOfSquare;
            }

            set
            {
                areaOfSquare = value;
            }

        }
        public double CalculateAreaOfSqure()
        {
            return Math.Pow(Side, 2);
        }
    }
}
