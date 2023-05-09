using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
	internal class MasterCard : Card
	{

		private int dailyOverDraft = 5000;

		public int DailyOverDraft 
		{
			get { return dailyOverDraft; }
		}

		private decimal monthlyOverDraft = 30000;

		public decimal MonthlyOverDraft
		{
			get { return monthlyOverDraft; }
		}


		public MasterCard(string CustName, int CustAge) : base(CustName, CustAge)
		{
			cardNumber = prefixes[rnd.Next(11,16)];

			while (cardNumber.Length < 16)
			{
				cardNumber += rnd.Next(10).ToString();
			}
			;
			while (accountNumber.Length < 14)
			{
				accountNumber += rnd.Next(10).ToString();
			}
		}


		public override string ToString()
		{
			return $"{GetType()} | Navn: {CustomerName} | Alder: {CustomerAge} | Kortnummer: {CardNumber} | Kontonummer: {AccountNumber} | Dagligt tilladt overtræk: {DailyOverDraft} | månedligt tilladt overtræk: {MonthlyOverDraft}";
		}
	}
}
