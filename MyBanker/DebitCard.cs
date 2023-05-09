using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	internal class DebitCard : Card
	{

		private bool internationalUse = false;

		public bool InternationalUse
		{
			get { return internationalUse; }
		}


		public DebitCard(string CustName, int CustAge) : base(CustName, CustAge)
		{
			cardNumber = prefixes[1];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}accountNumber = "3520";
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}
		}


		public override string ToString()
		{
			return $"{GetType()} | Navn: {CustomerName} | Alder: {CustomerAge} | Kortnummer: {CardNumber} | Kontonummer: {AccountNumber} | international? {InternationalUse} ";
		}
	}
}
