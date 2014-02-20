using System;
using System.Linq;

namespace Bank
{
	internal abstract class Customer
	{
		public Customer(string name)
		{
			this.Name = name;
		}

		public string Name { get; set; }
	}
}