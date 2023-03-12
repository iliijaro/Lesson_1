using System;
namespace HelloName_Lesson.GeometricalFigures
{
	internal class IsoscelesTriangle : Triangle
	{
		public double triangleHigh;

		public IsoscelesTriangle(double firstSide, double secondSide, double thirdSide) : base(firstSide, secondSide, thirdSide)
		{
		}

        public override double GetSquare()
        {
			if ((firstSide == secondSide) && (firstSide != thirdSide))
			{
                Console.WriteLine("Get square IsoscelesTriangle: ");
                triangleHigh = Math.Sqrt(4 * Math.Pow(firstSide, 2) - Math.Pow(thirdSide, 2)) / 2;
				return thirdSide * triangleHigh / 2;
            }
			else if ((firstSide == thirdSide) && (firstSide != secondSide))
			{
                Console.WriteLine("Get square IsoscelesTriangle: ");
                triangleHigh = Math.Sqrt(4 * Math.Pow(firstSide, 2) - Math.Pow(secondSide, 2)) / 2;
                return secondSide * triangleHigh / 2;
            }

            Console.WriteLine("Get square IsoscelesTriangle: ");
            triangleHigh = Math.Sqrt(4 * Math.Pow(thirdSide, 2) - Math.Pow(firstSide, 2)) / 2;
            return firstSide * triangleHigh / 2;
        }
    }
}

