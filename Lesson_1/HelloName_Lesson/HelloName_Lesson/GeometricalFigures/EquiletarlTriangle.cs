using System;
namespace HelloName_Lesson.GeometricalFigures
{
    internal class EquiletarlTriangle : Triangle
    {
        public EquiletarlTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square EquiletarlTriangle");
            return Math.Pow(firstSide, 2) * Math.Sqrt(3) / 4;
        }
    }
}

