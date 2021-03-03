using System;

namespace Task2
{
    class AreaCalculationAndComparison
    {

        public static void Main(string[] args)
        {
            double radiusOfCircle = CalculateAreaOfCircle();
            double sideOfSquare = CalculateAreaOfSquare();

            if (radiusOfCircle * 2 > sideOfSquare)
            {
                Console.WriteLine("\nSquare is in Circle");

            }
            else if (radiusOfCircle * 2 < sideOfSquare)
            {
                Console.WriteLine("\nCircle is in Square");
            }

            else
            {
                Console.WriteLine("\nCircle and Square are intersected");
            }
        }


        public static double CalculateAreaOfCircle()
        {
            int radiusNumberOfAttempts = 0;
            double returnRaduis = 0;
            while (radiusNumberOfAttempts < 3)
            {
                try
                {
                    Console.Write("\nEnter radius  ");
                    var radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"\nArea of circle with {circle.Radius} radius is {Math.Round(circle.AreaOfCircle, 2)}");
                    returnRaduis = radius;
                    break;
                }

                catch (Exception)
                {
                    Console.WriteLine($"\nRadius must be numeric!");
                    radiusNumberOfAttempts++;
                    if (radiusNumberOfAttempts == 3)
                    {
                        Random rnd = new Random();
                        double randomRadius = 0.5 + (rnd.NextDouble() * (5 - 0.5));
                        Circle circle = new Circle(randomRadius);
                        Console.WriteLine($"\nYou entered an invalid RADIUS value three times. Radius will be set randomly:  {Math.Round(circle.Radius, 2)}.  Area of circle is: {Math.Round(circle.AreaOfCircle, 2)}");
                        returnRaduis = randomRadius;
                        break;
                    }
                }

            }
            return returnRaduis;
        }

        public static double CalculateAreaOfSquare()
        {
                int sideNumberOfAttempts = 0;
                double returnSide = 0;

                while (sideNumberOfAttempts < 3)
                {
                    try
                    {
                        Console.Write("\nEnter side  ");
                        var side = Convert.ToDouble(Console.ReadLine());
                        Squre square = new Squre(side);
                        Console.WriteLine($"\nArea of squre with {square.Side} side is { Math.Round(square.AreaOfSquare, 2)}");
                    returnSide = side;
                        break;
                    }

                    catch (Exception)
                    {
                        Console.WriteLine($"\nSide must be numeric!");
                        sideNumberOfAttempts++;
                        if (sideNumberOfAttempts == 3)
                        {
                            Random rnd2 = new Random();
                            double randomSide = 0.5 + (rnd2.NextDouble() * (5 - 0.5));
                            Squre square = new Squre(randomSide);
                            Console.WriteLine($"\nYou entered an invalid SIDE value three times. Side will be selected randomly:  {Math.Round(square.Side, 2)}.  Area of square is: { Math.Round(square.AreaOfSquare, 2)}");
                            returnSide = randomSide;
                            break;
                        }
                    }
                }
                return returnSide;
        }

    }
}



