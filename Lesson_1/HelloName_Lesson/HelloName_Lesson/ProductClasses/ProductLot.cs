namespace HelloName_Lesson.ProductClasses
{
    public class ProductLot : Product
	{
        byte amountInLot;
		public ProductLot(string productName, double productPrice, byte amountInLot, string produceDate, string expirationDate) :base(productName, productPrice, produceDate, expirationDate)
		{
			this.amountInLot = amountInLot;
		}
	}
}