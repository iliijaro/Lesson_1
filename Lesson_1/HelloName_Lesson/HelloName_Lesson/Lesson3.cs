using System;
namespace HelloName_Lesson
{
    /// <summary>
    /// Создайте массив целых чисел. Напишете программу,
	/// которая выводит сообщение о том, входит ли заданное число в массив или нет.Пусть число для поиска задается с консоли.
    /// </summary>
    internal class Lesson3
	{
        public static void HomeTask3()
        {
            int[] Array = {7,2,3,4,7,1,4,7};

            Console.WriteLine("Enter the number to check its existence in the Array:" + "\n");
            float NumberFromConsole = float.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (NumberFromConsole == Array[i])
                {
                    count++;
                }   
            }
            if (count > 0)
            {
                Console.WriteLine("\n" + "Current number exists in the Array " + count + " time(s)");
            }
            else
            {
                Console.WriteLine("\n" + "Current number does not exist in the Array");
            }
        }
    }
}

