using System;
using System.Collections;
using System.IO;
using HelloName_Lesson.ProductClasses;

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

        public static void Task3()
        {
            List<Product> products = new List<Product>()
            {
                new Dairy("Milk", 4.50, "February 20, 2023", "March 21,2023"),
                new Flour("Bread", 10, "February 05, 2023", "March 28,2023"),
                new Beverages("Apple Juice", 7.20, "February 10, 2023", "March 10,2023"),
                new Flour("Cake", 3.40, "February 7, 2023", "March 23,2023"),
                new Dairy("Cheese", 12.10, "February 19, 2023", "March 21,2023"),
                new Beverages("Coke", 4.70, "February 12, 2023", "April 22 ,2023")
            };

            //Console.WriteLine("List of Products: \n");

            //foreach (var product in products)
            //{
            //    product.GetInfoProduct();
            //}

            //Console.WriteLine("Today is: " + DateTime.Today);
            //Console.WriteLine("Expired Products: \n");

            //foreach (var product in products)
            //{
            //    if (!product.CheckTheExpirationDate())
            //    {
            //        product.GetInfoProduct();
            //    }
            //}

            //Task 1.1
            //List<Product> products1_1 = new List<Product>()
            //{
            //    new Dairy("Milk", 4.50, "February 20, 2023", "March 21,2023"),
            //    new Flour("Bread", 10, "February 05, 2023", "March 28,2023"),
            //    new Beverages("Apple Juice", 7.20, "February 10, 2023", "March 10,2023"),
            //    new Flour("Cake", 3.40, "February 7, 2023", "March 23,2023"),
            //    new Dairy("Cheese", 12.10, "February 19, 2023", "March 21,2023"),
            //    new Beverages("Coke", 4.70, "February 12, 2023", "April 22 ,2023")
            //};
            //foreach (var product in products1_1)
            //{
            //    product.GetInfoProduct();
            //}

            //products1_1[1] = new Flour("Bread", 100, "February 05, 2023", "March 28,2023");

            //products1_1.RemoveAt(products1_1.Count - 1);

            //Console.WriteLine("\nNew price and deleted object:");

            //foreach (var product in products1_1)
            //{
            //    product.GetInfoProduct();
            //}

            //products1_1.Clear();

            //Task 1.2
            List<Product> products1_2 = new List<Product>()
            {
                new Dairy("Milk", 305, "February 20, 2023", "March 21,2023"),
                new Flour("Bread", 150, "February 05, 2023", "March 28,2023"),
                new Beverages("Apple Juice", 220, "February 10, 2023", "March 10,2023"),
                new Flour("Cake", 340, "February 7, 2023", "March 23,2023"),
                new Dairy("Cheese", 301, "February 19, 2023", "March 21,2023"),
                new Beverages("Coke", 290, "February 12, 2023", "April 22 ,2023")
            };

            List<Product> container = new List<Product>() { };

            //написать метод на это решение
            foreach (var product in products1_2)
            {
                if (product.productPrice > 300)
                {
                    container.Add(product);
                }
            }

            //вывод мин значения
            var minUnit = container[0].productPrice;

            foreach (var product in container)
            {
                if (minUnit >= product.productPrice)
                {
                    minUnit = product.productPrice;
                    
                }
            }
            Console.WriteLine(minUnit);




        }
    }
}