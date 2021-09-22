using System;
namespace Calculator
{
    public class FooCalc
    {
        public static int BarCalc(int width, int length, int depth)
        {
            return width * length * depth;
        }
        public static double HowManyBagsOfMulch(int area)
        {
            double sqftOfCoverage = 3456d;

            return area / sqftOfCoverage;
        }
        public static int parseReadLine(string message)
        {
            Console.WriteLine(message);

            while (true)
            {
                int num;
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    return num;
                }
                Console.WriteLine($"Did you input a number? {message}");
            }
        }
    }
}
