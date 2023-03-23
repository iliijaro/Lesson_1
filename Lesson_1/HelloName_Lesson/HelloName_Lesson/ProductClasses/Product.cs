using System;
namespace HelloName_Lesson.ProductClasses
{
    public abstract class Product
    {
        public string productName;
        public double productPrice;
        public string produceDate;
        public string expirationDate;
        public DateTime currentDate = DateTime.Today;

        public Product(string productName, double productPrice, string produceDate, string expirationDate)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.produceDate = produceDate;
            this.expirationDate = expirationDate;
        }

        public virtual void GetInfoProduct()
        {
            Console.WriteLine($"Product '{productName}' costs {productPrice}(BYN), produced on {produceDate} and expired on {expirationDate}\n");
        }

        public virtual bool CheckTheExpirationDate()
        {
            DateTime endDate = DateTime.Parse(expirationDate);
            if (endDate > currentDate)
            {
                return true;
            }
            return false;
        }

        public bool CheckThePrice(List<Product> initial)
        {
            foreach (var product in initial)
            {
                if (productPrice > 300)
                {
                    return true;
                }
            }
            return false;

        }
    }
}