using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Triangle triangle = new Triangle(1, 2, 3);
            // RectangularTriangle rectangularTriangle = new RectangularTriangle(4,5);
            RegularTriangle regularTriangle = new RegularTriangle();
            Triangle triangle = regularTriangle;
            if (triangle is RectangularTriangle)
            {
                // RectangularTriangle rectangularTriangle1 = triangle as RectangularTriangle;
                RectangularTriangle rectangularTriangle1 = (RectangularTriangle)triangle;
            }

            // Triangle triangle = rectangularTriangle;
            // RectangularTriangle rectangularTriangle1 = (RectangularTriangle)triangle;
            Console.ReadKey();
        }
    }
    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        //public virtual double GetArea()
        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle(double a, double b)
        //      : base(a, b, Math.Sqrt(a * a + b * b))
        {
            A = a;
            B = b;
            C = Math.Sqrt(a * a + b * b);
        }

        //public override double GetArea()
        public new double GetArea()
        {
        return A*B/2;  
        }
    }

    class RegularTriangle : Triangle
    {

    }
}
