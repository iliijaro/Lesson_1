using System;
using HelloName_Lesson.ExceptionClasses;
namespace HelloName_Lesson
{
    public class Lesson8
    {
        public static void Task()
        {
            NewCredits correctCredits = new("login123", "12345", "12345");
            var form1 = NewCredits.CheckCredits(correctCredits);
            Console.WriteLine(form1 + "\n");

            NewCredits incorrectLogin = new("L ogi n", "12345", "12345");
            var form2 = NewCredits.CheckCredits(incorrectLogin);
            Console.WriteLine(form2 + "\n");

            NewCredits incorrectPassword = new("login123", "12345678911234567891", "12345678911234567891");
            var form3 = NewCredits.CheckCredits(incorrectPassword);
            Console.WriteLine(form3 + "\n");

            NewCredits notMatchedPassword = new("login123", "123456789", "12345678911234567891");
            var form4 = NewCredits.CheckCredits(notMatchedPassword);
            Console.WriteLine(form4 + "\n");
        }
    }
}