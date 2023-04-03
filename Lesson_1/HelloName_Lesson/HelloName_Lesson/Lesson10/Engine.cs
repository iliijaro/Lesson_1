namespace HelloName_Lesson.Lesson10
{
    public abstract class Engine
    {
        public string type;

        public Engine(string type)
        {
            this.type = type;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Abstract Engine");
        }
    }
}