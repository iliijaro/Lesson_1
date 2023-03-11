using System;
using System.Reflection.Metadata;
using System.Text;
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
            string newString = "test and 1test 231231 best test";

            newString = newString.Replace("test", "testing");

            newString = Regex.Replace(newString, "[0-9]", "", RegexOptions.IgnoreCase);

            Console.WriteLine(newString);
        }

        /// <summary>
        /// Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lesons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>

        public static void HomeTask4_1()
        {
            string word1 = "\"Welcome\"";
            string word2 = "\"to\"";
            string word3 = "\"the\"";
            string word4 = "\"TMS\"";
            string word5 = "\"lesons\"";

            string[] сonnectedArray = new string[] { word1, word2, word3, word4, word5 };

            string сonnectedStrings = string.Join(" ", сonnectedArray);

            сonnectedStrings = сonnectedStrings.Replace("\"", "");

            Console.WriteLine(string.Join(" ", сonnectedStrings));
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        /// Результат вывести в консоль.
        /// </summary>

        public static void HomeTask4_2()
        {
            string precondition = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            Console.WriteLine("Original string: " + precondition + "\n");
            string subString = "abc";
            int indexOfSubstring = precondition.IndexOf(subString);

            string firstWord = precondition.Substring(0, indexOfSubstring);
            string secondWord = precondition.Substring(indexOfSubstring + 3);

            Console.WriteLine("First word:" + firstWord + "\n");
            Console.WriteLine("Second word: " + secondWord);
        }

        ///  <summary>
        ///  Дана строка: Плохой день.Необходимо с помощью метода substring удалить слово "плохой".
        ///  После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        ///  Заменить последний "!" на "?"
        ///  </summary>

        public static void HomeTask4_3()
        {
            string initialText = "PLOHOY DEN'";
            Console.WriteLine($"Initial text: {initialText}" + "\n");
           
            string croppedText = initialText.Substring(6);

            string newText = "HOROSHIY !!!!!!!!!";

            string finalText = newText.Insert(8,croppedText);

            finalText = finalText.Remove(finalText.Length - 1, 1) + "?";
            Console.WriteLine($"Final text: {finalText}");
        }

        /// <summary>
        /// Написать программу со следующим функционалом: На вход передать строку(будем считать, что это номер документа).
        /// Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,а y — это буква.
        /// </summary>

        public static void HomeTask4_4()
        {
            string documentNumber = "7788-lul-0033-see-4a2a";

            //Вывести на экран в одну строку два первых блока по 4 цифры.
            string[] onlyNumbers = documentNumber.Split("-");
            string numbersOnly = onlyNumbers[0] + " - " + onlyNumbers[2];

            Console.WriteLine($"First two blocks with numbers only: {numbersOnly}\n");

            //Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
            onlyNumbers[1] = "-***-";
            onlyNumbers[3] = "-***-";

            string allDocumentWithoutLetters = onlyNumbers[0] + onlyNumbers[1] + onlyNumbers[2] + onlyNumbers[3] + onlyNumbers[4];
            
            Console.WriteLine($"Whole document with the encrypted leters: {allDocumentWithoutLetters}\n");

            //Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.(реализовать с помощью класса StringBuilder).
            StringBuilder withoutNumbers = new StringBuilder(documentNumber);

            withoutNumbers.Remove(0, 5);
            withoutNumbers.Replace("-0033-", "/");
            withoutNumbers.Replace("-4", "/");
            withoutNumbers.Replace("2", "/");

            string textOnly = withoutNumbers.ToString();
            Console.WriteLine(textOnly.ToLower() + "\n");

            //Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре.
            Console.WriteLine($"Letters:" + textOnly.ToUpper() + "\n");

            //Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью)
            bool checkLowerCase = Regex.IsMatch(documentNumber, "\\babc\\b");
            bool checkUpperCase = Regex.IsMatch(documentNumber, "\\bABC\\b");

            if ((checkLowerCase == true) || (checkUpperCase == true))
            {
                Console.WriteLine("[ABC/abc] exists in the text\n");
            }
            else
            {
                Console.WriteLine("[ABC/abc] does not exist in the text\n");
            }

            //Проверить начинается ли номер документа с последовательности 555.

            if (documentNumber.StartsWith("555"))
            {
                Console.WriteLine("Document starts with 555\n");
            }
            else
            {
                Console.WriteLine("Document does not start with 555\n");
            }

            //Проверить заканчивается ли номер документа на последовательность 1a2b.

            if (documentNumber.EndsWith("1a2b"))
            {
                Console.WriteLine("Document ends with 1a2b\n");
            }
            else
            {
                Console.WriteLine("Document does not end with 1a2b\n");
            }
        }
    }
}

