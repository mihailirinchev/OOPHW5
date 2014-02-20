using System;
using System.Linq;

namespace Bank
{
	internal class DepositAccount : Account
	{
		public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
		{
		}

		public override decimal AmountForPeriod(uint months)
		{
			return (this.Balance >= 1000) ? (this.Balance * (1 + months * this.InterestRate)) : this.Balance;
		}
	}
}