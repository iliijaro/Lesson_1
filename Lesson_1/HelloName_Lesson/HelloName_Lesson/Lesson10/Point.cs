namespace HelloName_Lesson.Lesson10
{
    public class Point<T> where T : struct
    {
        public T x;
        public T y;

        public T X { get; private set; }
        public T Y { get; private set; }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Сoordinate x = {x} | Coordinate y = {y}");
        }

        public void GetTheDistance(Point<T> pointA, Point<T> pointB)
        {
            double x1 = Convert.ToDouble(pointA.x);
            double y1 = Convert.ToDouble(pointA.y);
            double x2 = Convert.ToDouble(pointB.x);
            double y2 = Convert.ToDouble(pointB.y);

            var calculateTheDistance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            Console.WriteLine($"Distance beetween two points: {calculateTheDistance}");
        }
    }
}

