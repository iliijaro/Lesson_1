using System;
namespace HelloName_Lesson.GeometricalFigures
{
    public class Square : Rectangle
    {
        public Square(double length, double width) : base(length, width)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square Square: ");
            return Math.Pow(length, 2);
        }
    }
}

