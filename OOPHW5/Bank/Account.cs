using System;
using System.Linq;

namespace Bank
{
	internal abstract class Account
	{
		public Account(Customer customer, decimal balance, decimal interestRate)
		{
			this.Customer = customer;
			this.Balance = balance;
			this.InterestRate = interestRate;
		}

		public Customer Customer { get; set; }

		public decimal Balance { get; set; }

		public decimal InterestRate { get; set; }

		public virtual void DepositMoney(decimal money)
		{
			this.Balance += money;
		}

		public virtual void WithDrawMoney(decimal money)
		{
			this.Balance -= money;
		}

		public abstract decimal AmountForPeriod(uint months);
	}
}