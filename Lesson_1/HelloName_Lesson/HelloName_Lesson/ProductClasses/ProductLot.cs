using System;
namespace HelloName_Lesson.ProductClasses
{
	public class ProductLot : Product
	{
		public ProductLot(string productName, double productPrice, byte amountInLot, string produceDate, string expirationDate) :base(productName, productPrice, produceDate, expirationDate) { }
	}
}

