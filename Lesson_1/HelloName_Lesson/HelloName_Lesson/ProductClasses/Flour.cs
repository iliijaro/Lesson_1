namespace HelloName_Lesson.ProductClasses
{
    public class Flour : Product
    {
        public Flour(string productName, double productPrice, string produceDate, string expirationDate) : base(productName, productPrice, produceDate, expirationDate) { }

        public Flour(string productName) : base(productName) { }

        public override void GetInfoProduct()
        {
            Console.WriteLine($"Product '{productName}' costs {productPrice}(BYN), produced on {produceDate} and expired on {expirationDate}\n");
        }

        public override bool CheckTheExpirationDate()
        {
            DateTime endDate = DateTime.Parse(expirationDate);
            if (endDate > currentDate)
            {
                return true;
            }
            return false;
        }
    }
}