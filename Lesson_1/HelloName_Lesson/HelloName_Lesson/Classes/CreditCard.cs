using System;
namespace HelloName_Lesson.Classes
{
	public class CreditCard
	{
		public long numberOfAccount;
		public double currentBalance;
		public double amountToAdd;
		public double amountToRecieve;

		public CreditCard(long numberOfAccount, double currentBalance)
		{
			this.numberOfAccount = numberOfAccount;
			this.currentBalance = currentBalance;
		}

		public CreditCard(long numberOfAccount) : this(numberOfAccount,1000)
		{
		}

		public CreditCard()
		{
        }

		public double AddMoney(double amountToAdd)
		{
			currentBalance += amountToAdd;
			return currentBalance;
		}

		public double ReceiveMoney(double amountToRecive)
		{
			currentBalance -= amountToRecive;
			return amountToRecive;
		}

		public void GetBalance()
		{
			if ((numberOfAccount != 0) && (currentBalance != 0))
			{
				Console.WriteLine($"This is your card{numberOfAccount: ####-####-####-####} balance: {currentBalance}$\n");
			}
			else
			{
				Console.WriteLine("The card does not exist");

            }

		}
	}
}

