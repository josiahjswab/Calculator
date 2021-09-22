using System;
using static Calculator.FooCalc;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthParsed = parseReadLine("How wide is the area in inches");

            int length = parseReadLine("How long is the area in inches");

            int depth = parseReadLine("How deep is the area in inches");

            int area = FooCalc.BarCalc(widthParsed, length, depth);

            double howMany = FooCalc.HowManyBagsOfMulch(area);

            Console.WriteLine($"You need {Math.Round(howMany, 2)} bags");
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey();
        }
    }
}
