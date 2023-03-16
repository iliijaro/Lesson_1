using System;
namespace HelloName_Lesson.Classes
{
    public class Phone
    {
        public string number;
        public string model;
        public double weight;

        public Phone(string number, string model, double weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public Phone(string number, string model) : this(number, model, 500) { }

        public Phone(string number) : this(number, "No model") { }

        public Phone() : this("+37529*******") { }

        public void GetInfo()
        {
            Console.WriteLine($"Number: {number}, Model: {model}, Weight: {weight} gramm\n");
        }

        public void GetNumber()
        {
            Console.WriteLine($"The number is: {number}\n");
        }
    }
}