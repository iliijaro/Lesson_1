using System;
namespace HelloName_Lesson.GeometricalFigures
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
        {
        }

        public override double GetSquare()
        {
            if (firstSide > secondSide)
            {
                if (firstSide > thirdSide)
                {
                    Console.WriteLine("Get square RightTriangle:");
                    return GetSquareForRightTriangle(secondSide, thirdSide);
                }
                else
                {
                    Console.WriteLine("Get square RightTriangle:");
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
            else
            {
                if (secondSide > thirdSide)
                {
                    Console.WriteLine("Get square RightTriangle:");
                    return GetSquareForRightTriangle(firstSide, thirdSide);
                }
                else
                {
                    Console.WriteLine("Get square RightTriangle:");
                    return GetSquareForRightTriangle(firstSide, secondSide);
                }
            }
        }

        private double GetSquareForRightTriangle(double firstSide, double secondSide)
        {
            return 0.5 * firstSide * secondSide;
        }
    }
}

