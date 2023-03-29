using System.Collections;
using System.Numerics;
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

            Console.WriteLine("List of Products: \n");

            foreach (var product in products)
            {
                product.GetInfoProduct();
            }

            Console.WriteLine("Today is: " + DateTime.Today);
            Console.WriteLine("Expired Products: \n");

            foreach (var product in products)
            {
                if (!product.CheckTheExpirationDate())
                {
                    product.GetInfoProduct();
                }
            }

            //// Task 1.1
            List<Product> products1_1 = new List<Product>()
            {
                new Dairy("Milk", 4.50, "February 20, 2023", "March 21,2023"),
                new Flour("Bread", 10, "February 05, 2023", "March 28,2023"),
                new Beverages("Apple Juice", 7.20, "February 10, 2023", "March 10,2023"),
                new Flour("Cake", 3.40, "February 7, 2023", "March 23,2023"),
                new Dairy("Cheese", 12.10, "February 19, 2023", "March 21,2023"),
                new Beverages("Coke", 4.70, "February 12, 2023", "April 22 ,2023")
            };

            foreach (var product in products1_1)
            {
                product.GetInfoProduct();
            }

            products1_1[1] = new Flour("Bread", 100, "February 05, 2023", "March 28,2023");

            products1_1.RemoveAt(products1_1.Count - 1);

            Console.WriteLine("\nNew price and deleted object:");

            foreach (var product in products1_1)
            {
                product.GetInfoProduct();
            }

            products1_1.Clear();

            //Task 1.2
            List<Product> products1_2 = new List<Product>()
            {
                new Dairy("Milk", 305, "February 20, 2023", "March 21,2023"),
                new Flour("Bread", 150, "February 05, 2023", "March 28,2023"),
                new Beverages("Apple Juice", 220, "February 10, 2023", "March 10,2023"),
                new Flour("Cake", 340, "February 7, 2023", "March 23,2023"),
                new Dairy("Cheese", 309, "February 19, 2023", "March 21,2023"),
                new Beverages("Coke", 290, "February 12, 2023", "April 22 ,2023")
            };

            var container = new List<Product>() { };

            //Не получилось сделать методы в качестве интерфейса, если можно потом помочь с этим? :)
            static void CheckThePrice(List<Product> products, List<Product> products1)
            {
                foreach (var product in products)
                {
                    if (product.productPrice > 300)
                    {
                        products1.Add(product);
                    }
                }
            }

            static void GetTheMinimumPrice(List<Product> products)
            {
                var minUnit = products[0].productPrice;
                var minProd = products[0];

                foreach (var product in products)
                {
                    if (minUnit >= product.productPrice)
                    {
                        minUnit = product.productPrice;
                        minProd = product;
                    }
                }
                Console.WriteLine("The minimal price product from the list: ");
                minProd.GetInfoProduct();
            }

            CheckThePrice(products1_2, container);
            GetTheMinimumPrice(container);

            //Task 1.3
            var productsInStore = new Dictionary<Product, int>()
            {
                [new Dairy("Milk")] = 10,
                [new Dairy("Cheese")] = 25,
                [new Flour("Cake")] = 5,
                [new Flour("Bread")] = 30,
                [new Beverages("Apple Juice")] = 24,
                [new Beverages("Coke")] = 22,
            };

            static void GetTheProductsInfo(Dictionary<Product, int> productsInStore)
            {
                foreach (KeyValuePair<Product, int> product in productsInStore)
                {
                    var productKey = Product.GetInfoProduct(product.Key);
                    Console.WriteLine($"{productKey}, Count = {product.Value}");
                }
                Console.WriteLine();
            }

            static void GetTheProductsNames(Dictionary<Product, int> productsInStore)
            {
                foreach (KeyValuePair<Product, int> product in productsInStore)
                {
                    var productKey = Product.GetInfoProduct(product.Key);
                    Console.WriteLine($"{productKey}");
                }
                Console.WriteLine();
            }

            static void GetTheProductsCount(Dictionary<Product, int> productsInStore)
            {
                foreach (KeyValuePair<Product, int> product in productsInStore)
                {
                    Console.WriteLine($"Count: {product.Value}");
                }
                Console.WriteLine();
            }

            GetTheProductsInfo(productsInStore);
            GetTheProductsNames(productsInStore);
            GetTheProductsCount(productsInStore);

            //Dictionary To List
            Console.WriteLine("From Dictionary to List: ");

            var fromDictionary = new List<Product>(productsInStore.Keys);

            foreach (var product in fromDictionary)
            {
                var productFromList = Product.GetInfoProduct(product);
                Console.WriteLine($"{productFromList}");
            }

            Console.WriteLine();

            //List To Dictionary
            Console.WriteLine("From List to Dictionary:");

            var fromList = fromDictionary.ToDictionary(Product => Product); //Нашёл способ через лямбду, но не знаю, как сделать по-другому

            foreach (var product in fromList)
            {
                var productKey = Product.GetInfoProduct(product.Key);
                Console.WriteLine($"{productKey}");
            }
        }
    }
}