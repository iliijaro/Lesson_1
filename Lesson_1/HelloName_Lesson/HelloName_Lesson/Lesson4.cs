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

        /// <summary>
        /// Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lesons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>

        public static void HomeTask4_1()
        {
            string Word1 = "\"Welcome\"";
            string Word2 = "\"to\"";
            string Word3 = "\"the\"";
            string Word4 = "\"TMS\"";
            string Word5 = "\"lesons\"";

            string[] ConnectedArray = new string[] { Word1, Word2, Word3, Word4, Word5 };

            string ConnectedStrings = string.Join(" ", ConnectedArray);

            ConnectedStrings = ConnectedStrings.Replace("\"", "");

            Console.WriteLine(string.Join(" ", ConnectedStrings));
        }
    }
}

