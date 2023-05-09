using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	internal class Maestro : Card
	{
		public Maestro(string CustName, int CustAge) : base(CustName, CustAge)
		{
			cardNumber = prefixes[rnd.Next(2,11)];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}
			
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}
		}
	}
}
