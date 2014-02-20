using System;
using System.Linq;

namespace Bank
{
	internal class LoanAccount : Account
	{
		public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
		{
		}

		public override void WithDrawMoney(decimal money)
		{
			throw new Exception("Can't withdraw money with Loan Account");
		}

		public override decimal AmountForPeriod(uint months)
		{
			var gratisPeriod = this.Customer is Individual ? 3 : 2;
			
			return months > gratisPeriod ? this.Balance * (1 + (months - gratisPeriod) * this.InterestRate) : this.Balance;
		}
	}
}