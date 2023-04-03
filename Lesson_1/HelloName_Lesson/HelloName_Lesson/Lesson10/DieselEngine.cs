namespace HelloName_Lesson.Lesson10
{
    public class DieselEngine : Engine
    {
        public DieselEngine(string type = "Diesel") : base(type) { }

        public override void GetInfo()
        {
            Console.WriteLine("Diesel engine");
        }
    }
}