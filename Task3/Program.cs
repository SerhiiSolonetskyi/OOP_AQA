using System;
using System.Linq;
namespace Task3
{
    class Program
    {
        public static int elementsCount;
        public static int minValue;
        public static int maxValue;
        public static int sumOfvalues;
        static void Main(string[] args)
        {
            EnterElementsCount();
            EnterMinValue();
            EnterMaxValue();

            int[] array= Enumerable.Range(minValue, maxValue).ToArray();

            for (int i = 0; i < elementsCount; i++)
            {
                if ((array[i] % 3 == 0) && !(array[i] % 5 == 0))
                {

                    sumOfvalues += array[i];

                }
                
            }

            Console.Write($"\nSum of values is {sumOfvalues} ");
        }
        public static int EnterElementsCount()
        {
        again:
            Console.WriteLine("\nPlese enter number Of values (should be more than 10!) ");
            elementsCount = Convert.ToInt32(Console.ReadLine());
            if (elementsCount <= 10)
            {
                Console.WriteLine("\nNumber Of values should be more than 10! Try again");
                goto again;
            }

            return elementsCount;
        }

        public static int EnterMinValue()
        {
            Console.WriteLine("\nEnter min value");
            return minValue = Convert.ToInt32(Console.ReadLine());

        }

        public static int EnterMaxValue()
        {
        again:
            Console.WriteLine("\nEnter max value");
            maxValue = Convert.ToInt32(Console.ReadLine());

            if (maxValue <= minValue)
            {
                Console.WriteLine("\nMax value should be more than min value!");
                goto again;
            }

            return maxValue;
           
            }
        }
    }