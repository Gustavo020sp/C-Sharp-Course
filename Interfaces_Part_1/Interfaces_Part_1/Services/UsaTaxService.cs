using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Part_1.Services
{
	internal class UsaTaxService : ITaxService
	{
		public double Tax(double amount)
		{
			if (amount <= 100)
			{
				return amount * 0.05;
			}
			else
			{
				return amount * 0.1;
			}
		}
	}
}
