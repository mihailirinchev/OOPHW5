using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank
{
	internal class Bank
	{
		private readonly List<Account> accounts;

		public Bank(params Account[] accounts)
		{
			this.accounts = new List<Account>(accounts);
		}

		public IEnumerable<Account> Accounts
		{
			get
			{
				return this.accounts;
			}
		}

		public void AddAccount(Account account)
		{
			this.accounts.Add(account);
		}

		public void RemoveAccount(Account account)
		{
			this.accounts.Remove(account);
		}
	}
}