using System;
using System.Linq;

namespace Bank
{
	class MortageAccount : Account
	{
		public MortageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
		{
		}

		public override void WithDrawMoney(decimal money)
		{
			throw new Exception("Can't withdraw money with MortageAccount");
		}

		public override decimal AmountForPeriod(uint months)
		{
			var amount = 0M;

			if (this.Customer is Company)
			{
				amount = this.Balance * (1 + Math.Min(months, 12) * this.InterestRate / 2);

				if (months > 12)
				{
					amount += this.Balance * (1 + (months - 12) * this.InterestRate);
				}
			}
			else if (this.Customer is Individual)
			{
				amount = months > 6 ? (this.Balance * (1 + (months - 6) * this.InterestRate)) : this.Balance;
			}

			return amount;
		}
	}
}