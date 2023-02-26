using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            int[] Array = { 1, 2, 3, 4, 4, 3, 2, 1 };

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

        /// <summary>
        /// Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
        /// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        /// В результате должен быть новый массив без указанного числа.
        /// </summary>

        public static void HomeTask3_1()
        {
            int[] Array = { 1, 2, 1, 3, 4, 3, 1, 4, 5 };
            int count = 0;

            //Вывод всех элементов
            Console.WriteLine("Elements before deletion:");
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + Array[i]);
            }

            //Ввод числа с клавиатуры
            Console.WriteLine("\n" +"Enter the number to delete it from the Array:");
            int NumberFromConsole = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Основной цикл
            for (int i = 0; i < Array.Length; i++) 
            {
                if (NumberFromConsole == Array[i])
                {
                    count++;
                    for (int j = i; j < Array.Length - count; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                }
            }

            //Вывод сообщения в консоль/Вывод нового массива
            if (count == 0)
            {
                Console.WriteLine("This number does not existing in the array");
            }
            else if (count != 0)
            {
                Console.WriteLine("Elements after deletion: ");
                for (int j = 0; j < Array.Length - count; j++)
                {
                    Console.WriteLine("Element[" + (j) + "]: " + Array[j]);
                }
                Console.WriteLine();
            }
        }
    }
}