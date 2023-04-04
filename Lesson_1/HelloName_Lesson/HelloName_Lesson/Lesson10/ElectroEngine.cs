namespace HelloName_Lesson.Lesson10
{
    public class ElectroEngine : Engine
    {
        public ElectroEngine(string type = "Electro") : base(type) { }

        public override void GetInfo()
        {
            Console.WriteLine("Electro engine");
        }
    }
}