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

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>

        public static void HomeTask4_2()
        {
            string Precondition = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            Console.WriteLine("Original string: " + Precondition + "\n");
            string subString = "abc";
            int indexOfSubstring = Precondition.IndexOf(subString);

            string FirstWord = Precondition.Substring(0, indexOfSubstring);
            string SecondWord = Precondition.Substring(indexOfSubstring + 3);

            Console.WriteLine("First word:" + FirstWord + "\n");
            Console.WriteLine("Second word: " + SecondWord);
        }

        ///  <summary>
        ///  Дана строка: Плохой день.Необходимо с помощью метода substring удалить слово "плохой".
        ///  После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        ///  Заменить последний "!" на "?"
        ///  </summary>

        public static void HomeTask4_3()
        {
            string InitialText = "PLOHOY DEN'";
            Console.WriteLine($"Initial text: {InitialText}" + "\n");
           
            string CroppedText = InitialText.Substring(6);

            string NewText = "HOROSHIY !!!!!!!!!";

            string FinalText = NewText.Insert(8,CroppedText);

            FinalText = FinalText.Remove(FinalText.Length - 1, 1) + "?";
            Console.WriteLine($"Final text: {FinalText}");
        }
    }
}

