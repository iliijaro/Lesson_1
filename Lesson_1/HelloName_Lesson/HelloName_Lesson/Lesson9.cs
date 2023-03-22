using System;
using System.Collections;

namespace HelloName_Lesson
{
    public class Lesson9
    {
        public static void Task1()
        {
            ArrayList list = new ArrayList();

            try
            {
                object? s = list[18];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message, ex.Source, ex.Data);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Task2()
        {
            Dictionary<int, string> ukrLeague = new Dictionary<int, string>()
            {
                { 1, "Obolon"},
                { 2, "Dynamo Kiev"},
                { 3, "Torpedo"},
                { 4, "Shaxter" },
                { 5, "Harkov"},
                { 6, "Karpaty"},
                { 7, "Lviv"},
                { 8, "Herson FC"},
                { 9, "Dynamo Irpen" },
                { 10, "FC Odessa"}
            };

            Console.WriteLine("Ukrainian Football League table:");

            foreach (var team in ukrLeague)
            {
                var teamFormat = String.Format("{0} - {1} ", team.Key, team.Value);
                Console.WriteLine(teamFormat);
            }
        }
    }
}