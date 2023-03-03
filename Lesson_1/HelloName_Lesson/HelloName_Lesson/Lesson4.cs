using System;
using System.Text.RegularExpressions;

namespace HelloName_Lesson
{
	internal class Lesson4
	{
        /// <summary>
        /// Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
        /// </summary>
        
        public static void HomeTask4()
		{
            string NewString = "test and 1test 231231 best test";

            NewString = NewString.Replace("test", "testing");

            NewString = Regex.Replace(NewString, "[0-9]", "", RegexOptions.IgnoreCase);

            Console.WriteLine(NewString);
        }
    }
}

