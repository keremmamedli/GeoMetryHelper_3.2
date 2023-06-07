using System;

namespace GeometryHelper_3._2_
{
    static class GeometryHelper
    {
        public static double AreaofSquare(double SideofSquare)
        {
            return Math.Pow(SideofSquare, 2);
        }

        public static double AreaofTriangle(double SideofTriangle)
        {
            return (Math.Pow(SideofTriangle, 2) * Math.Sqrt(3)) / 4;
        }

        public static double AreaofCircle(double RadiusofCircle)
        {
            return Math.PI * Math.Pow(RadiusofCircle, 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double SideofSquare = 2;
            double SideofTriangle = 3;
            double RadiusofCircle = 1;

            double squarArea = GeometryHelper.AreaofSquare(SideofSquare);
            Console.WriteLine("Area of Squere = " + squarArea);

            double triangleArea = GeometryHelper.AreaofTriangle(SideofTriangle);
            Console.WriteLine("Area of Triangle: " + triangleArea);

            double circlearea = GeometryHelper.AreaofCircle(RadiusofCircle);
            Console.WriteLine("Area of Circle = " +  circlearea);
        }
    }
}
