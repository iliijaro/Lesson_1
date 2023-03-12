using System;
namespace HelloName_Lesson.GeometricalFigures
{
    internal class Triangle : Figure
    {
        public double firstSide;

        public double secondSide;

        public double thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public Triangle()
        {
            Console.WriteLine("The Triangle does not exist ");
        }

        public override double GetSquare()
        {
            Console.WriteLine("Get square Heron formula: ");
            double semiPerimetr = (firstSide + secondSide + thirdSide) / 2;
            return Math.Sqrt(semiPerimetr * (semiPerimetr - firstSide) * (semiPerimetr - secondSide) * (semiPerimetr - thirdSide));
        }
    }
}

