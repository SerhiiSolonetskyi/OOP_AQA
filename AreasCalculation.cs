using System;

namespace Task1
{
    class AreasCalculation
    {
        public static void Main(string[] args)
        {
            int radiusNumberOfAttempts = 0;
            int sideNumberOfAttempts = 0;
            while (radiusNumberOfAttempts < 3)
            {
                try
                {
                    Console.Write("\nEnter radius  ");
                    var radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    Console.WriteLine($"\nArea of circle with {circle.Radius} radius is { Math.Round(circle.AreaOfCircle, 2)}");
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
                        Console.WriteLine($"\nYou entered an invalid RADIUS value three times. Radius will be set randomly:  {Math.Round(circle.Radius, 2)}.  Area of circle is: { Math.Round(circle.AreaOfCircle, 2)}");
                        break;
                    }
                }
            }

            while (sideNumberOfAttempts < 3)
            {
                try
                {
                    Console.Write("\nEnter side  ");
                    var side = Convert.ToDouble(Console.ReadLine());
                    Squre squre = new Squre(side);
                    Console.WriteLine($"\nArea of squre with {squre.Side} side is { Math.Round(squre.AreaOfSquare, 2)}");
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
                        Squre squre = new Squre(randomSide);
                        Console.WriteLine($"\nYou entered an invalid SIDE value three times. Side will be selected randomly:  {Math.Round(squre.Side, 2)}.  Area of square is: { Math.Round(squre.AreaOfSquare, 2)}");
                        break;
                    }
                }
            }
        }
    }
}

