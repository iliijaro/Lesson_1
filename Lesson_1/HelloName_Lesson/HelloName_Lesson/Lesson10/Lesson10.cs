namespace HelloName_Lesson.Lesson10
{
    public class Lesson10
    {
        public static void Task1()
        {
            MyList<string> newArray = new MyList<string>();
            newArray.Add("Hello");
            newArray.Add("I");
            newArray.Add("am");
            newArray.Add("Array");

            newArray.Delete("I");
            newArray.Delete("Hello");

            Console.WriteLine(newArray.GetElement(1) + "\n");

            Console.WriteLine(newArray.Count() + "\n");

            for (int i = 0; i < newArray.Count(); i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
    }
}