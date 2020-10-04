using System;

namespace Line_Comparison_Problem_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program");
            Console.WriteLine(" 1. To calculate the distance between two points: ");
            Console.WriteLine(" 2. To compate the lenghts of two lines");
            Program n = new Program();
            int input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1:
                    double distance = n.DistanceBetPoints();
                    break;
                case 2:
                    Console.WriteLine("\nFor line 1: ");
                    double line_one = n.DistanceBetPoints();
                    Console.WriteLine("\nFor line 2: ");
                    double line_two = n.DistanceBetPoints();
                    if (line_one > line_two)
                        Console.WriteLine("The length of line 1 is greater than line 2");
                    if (line_two == line_one)
                        Console.WriteLine("Both the lines are of same length");
                    else
                        Console.WriteLine("The length of line 2 is greater than line 1");
                    break;

            }

        }
        public double DistanceBetPoints()
        {
            Console.WriteLine("Enter the coordinates of the first point: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the second point: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double distance = (Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)));
            Console.WriteLine("The distance between the given points is: " + distance +"\n");
            return distance;
        }
    }
}
