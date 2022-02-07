using System;
using System.Collections;

/// <summary>
/// DONE BY: PAVAN
/// PURPOSE: CALCULATING THE AREA AND PERIMETER OF CIRCLE, SQUARE, TRIANGLE, RECTANGLE:///
/// </summary>

namespace Day11Project1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.WriteLine("******RADIUS*******");
            Console.Write("Enter Radius Value : ");
            radius = Convert.ToInt32(Console.ReadLine());

        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.Write("Enter  the side of a Square : ");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return 4 * side;
        }
        public int CalculateArea()
        {
            return side * side;
        }
    }
    class Rectangle : IShape
    {
        private int lgt;
        private int wdt;
        public void ReadSide()
        {
            Console.WriteLine("*******LENGTH AND WIDTH OF A RECTANGLE****");
            Console.Write("Enter Length of a Rectangle : ");
            lgt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of a Rectangle : ");
            wdt = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return 2 * (lgt + wdt);
        }
        public int CalculateArea()
        {
            return lgt * wdt;
        }
    }
    class Triangle : IShape
    {
        private int s1;
        private int s2;
        private int s3;
        public void ReadSides()
        {
            Console.WriteLine("*****SIDES OF TRIANGLE******");
            Console.Write("Enter s1 of a Triangle : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter s2 of a Triangle : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter s3 of a Triangle : ");
            s3 = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return s1 + s2 + s3;
        }
        public int CalculateArea()
        {
            double semiperimeter = (s1 + s2 + s3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - s1) * (semiperimeter - s2) * (semiperimeter - s3));
            return Convert.ToInt32(Area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.ReadRadius();
            Console.WriteLine("***** CIRCLE******");
            Console.WriteLine($"The Perimeter of Circle is : {circle.CalculatePerimeter()}");
            Console.WriteLine($"The Area of Circle is :{circle.CalculateArea()} ");

            Square square = new Square();
            square.ReadSide();
            Console.WriteLine("*****SQUARE*****");
            Console.WriteLine($"The Perimeter of Square is :{square.CalculatePerimeter()}");
            Console.WriteLine($"The Area of Square is :{square.CalculateArea()}");

            Rectangle rectangle = new Rectangle();
            rectangle.ReadSide();
            Console.WriteLine("*****RECTANGLE***");
            Console.WriteLine($"The Perimeter of a Rectangle is :{rectangle.CalculatePerimeter()}");
            Console.WriteLine($"The Area of a Rectangle is :{rectangle.CalculateArea()}");

            Triangle tri = new Triangle();
            tri.ReadSides();
            Console.WriteLine("****TRIANGLE****");
            Console.WriteLine($"The Perimeter of a given Triangle is :{tri.CalculatePerimeter()}");
            Console.WriteLine($"The Area of a Triangle is : {tri.CalculateArea()}");

            Console.ReadLine();
        }
    }
}