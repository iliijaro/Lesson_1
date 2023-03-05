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

        /// <summary>
        /// Написать программу со следующим функционалом: На вход передать строку(будем считать, что это номер документа).
        /// Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,а y — это буква.
        /// </summary>

        public static void HomeTask4_4()
        {
            string DocumentNumber = "7788-lul-0033-see-4a2a";

            //Вывести на экран в одну строку два первых блока по 4 цифры.
            string[] OnlyNumbers = DocumentNumber.Split("-");
            string numbersOnly = OnlyNumbers[0] + " - " + OnlyNumbers[2];

            Console.WriteLine($"First two blocks with numbers only: {numbersOnly}\n");

            //Вывести на экран номер документа, но блоки из трех букв заменить на *** (каждая буква заменятся на *).
            OnlyNumbers[1] = "-***-";
            OnlyNumbers[3] = "-***-";

            string AllDocumentWithoutLetters = OnlyNumbers[0] + OnlyNumbers[1] + OnlyNumbers[2] + OnlyNumbers[3] + OnlyNumbers[4];
            
            Console.WriteLine($"Whole document with the encrypted leters: {AllDocumentWithoutLetters}\n");

            //Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.(реализовать с помощью класса StringBuilder).
            StringBuilder WithoutNumbers = new StringBuilder(DocumentNumber);

            WithoutNumbers.Remove(0, 5);
            WithoutNumbers.Replace("-0033-", "/");
            WithoutNumbers.Replace("-4", "/");
            WithoutNumbers.Replace("2", "/");

            string TextOnly = WithoutNumbers.ToString();
            Console.WriteLine(TextOnly.ToLower() + "\n");

            //Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре.
            Console.WriteLine($"Letters:" + TextOnly.ToUpper() + "\n");

            //Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью)
            bool CheckLowerCase = Regex.IsMatch(DocumentNumber, "\\babc\\b");
            bool CheckUpperCase = Regex.IsMatch(DocumentNumber, "\\bABC\\b");

            if (CheckLowerCase == true || CheckUpperCase == true)
            {
                Console.WriteLine("[ABC/abc] exists in the text\n");
            }
            else
            {
                Console.WriteLine("[ABC/abc] does not exist in the text\n");
            }

            //Проверить начинается ли номер документа с последовательности 555.

            if (DocumentNumber.StartsWith("555"))
            {
                Console.WriteLine("Document starts with 555\n");
            }
            else
            {
                Console.WriteLine("Document does not start with 555\n");
            }

            //Проверить заканчивается ли номер документа на последовательность 1a2b.

            if (DocumentNumber.EndsWith("1a2b"))
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

