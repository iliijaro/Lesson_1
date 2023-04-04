namespace HelloName_Lesson.Lesson10
{
    public class GasEngine : Engine
    {
        public GasEngine(string type = "Gasoline") : base(type) { }

        public override void GetInfo()
        {
            Console.WriteLine("Gasoline engine");
        }
    }
}