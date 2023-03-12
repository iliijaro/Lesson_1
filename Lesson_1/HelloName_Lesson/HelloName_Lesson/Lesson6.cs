using System;
using HelloName_Lesson.GeometricalFigures;

namespace HelloName_Lesson
{
	public class Lesson6
	{
		public static void Task1()
		{
            Triangle? triangle = new TriangleBuilder().CreateTriangle(5, 6, 10);
            Triangle? triangle1 = new TriangleBuilder().CreateTriangle(3, 4, 5);
            Triangle? triangle2 = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Triangle? triangle3 = new TriangleBuilder().CreateTriangle(6, 6, 10);

            //Console.WriteLine(triangle?.GetSquare().ToString("#.##"));
            //Console.WriteLine(triangle1?.GetSquare().ToString("#.##"));
            //Console.WriteLine(triangle2?.GetSquare().ToString("#.##"));
            //Console.WriteLine(triangle3?.GetSquare().ToString("#.##"));

            Rectangle rectangle = new RectangleBuilder().CreateRectangle(4,4);
            Rectangle rectangle1 = new RectangleBuilder().CreateRectangle(5, 7);

            //Console.WriteLine(rectangle?.GetSquare().ToString("#.##"));
            //Console.WriteLine(rectangle1?.GetSquare().ToString("#.##"));

            var arrayOfFigures = new Figure[] {triangle, triangle1, triangle2, triangle3,  rectangle, rectangle1};

            foreach (var figure in arrayOfFigures)
            {
                if (figure != null)
                {
                    Console.WriteLine(figure.GetSquare().ToString("#.##")+"\n");
                }
            }

        }
	}
}

