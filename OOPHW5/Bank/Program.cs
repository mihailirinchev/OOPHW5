using System;
using System.Linq;

namespace Bank
{
	class Program
	{
		static void Main()
		{
			var accounts = new Account[]
			{
				new LoanAccount(new Individual("Pesho Peshev"), 100, 0.05M),
				new LoanAccount(new Company("Telerik"), 500000000, 0.08M),
				new MortageAccount(new Individual("Gosho Peshev"), 400, 0.03M),
				new MortageAccount(new Company("Microsoft"), 8000, 0.20M),
				new DepositAccount(new Individual("Tosho Toshev"), 333, 0.05M),
			};

			var fiBank = new Bank(accounts);

			fiBank.AddAccount(new DepositAccount(new Company("Google"), 8358, 0.01M));

			foreach (var account in fiBank.Accounts)
			{
				for (var i = 1; i < 5; i++)
				{
					Console.WriteLine("{0} will have balance {1} after {2} months", account.Customer.Name, account.AmountForPeriod((uint)i * 6), i * 6);
				}

				Console.WriteLine("-------------------------------------------------------------");
			}
		}
	}
}