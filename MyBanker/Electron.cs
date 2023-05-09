using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{

	internal class Electron : Card
	{
		private decimal monthlyAllowedUsage = 10000;

		public decimal MonthlyAllowedUsage
		{
			get { return monthlyAllowedUsage; }
			set { monthlyAllowedUsage = value; }
		}

		public Electron(string CustName, int CustAge) : base(CustName, CustAge)
		{
			cardNumber = prefixes[rnd.Next(16,21)];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}
		}


		public override string ToString()
		{
			return $"{GetType()} | Navn: {CustomerName} | Alder: {CustomerAge} | Kortnummer: {CardNumber} | Kontonummer: {AccountNumber} | månedligt tilladt spenditur: {MonthlyAllowedUsage}";
		}
	}
}
