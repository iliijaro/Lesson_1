using System;
namespace HelloName_Lesson.GeometricalFigures
{ 
    public class Rectangle : Figure
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square Rectangle: ");
            return length * width;
        }
    }
}